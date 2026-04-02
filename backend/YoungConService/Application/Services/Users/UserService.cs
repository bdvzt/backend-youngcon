using FluentValidation;
using YoungConService.Domain.Entities;
using YoungConService.Domain.Enums;
using YoungConService.DTOs;
using YoungConService.DTOs.Users;
using YoungConService.Infrastructure.Auth;
using YoungConService.Infrastructure.Errors.Exceptions;
using YoungConService.Infrastructure.Mappers;
using YoungConService.Infrastructure.Repositories;
using ValidationException = YoungConService.Infrastructure.Errors.Exceptions.ValidationException;

namespace YoungConService.Services;

public class UserService(
    IUserRepository userRepository,
    IValidator<CreateUserRequest> userValidator,
    IValidator<PagedRequest> pagedRequestValidator,
    ICurrentUser currentUser)
    : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IValidator<CreateUserRequest> _userValidator = userValidator;
    private readonly IValidator<PagedRequest> _pagedRequestValidator = pagedRequestValidator;
    private readonly ICurrentUser _currentUser = currentUser;

    public async Task<User> CreateUserAsync(CreateUserRequest dto)
    {
        var validationResult = await _userValidator.ValidateAsync(dto);

        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors
                .GroupBy(e => e.PropertyName)
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(e => e.ErrorMessage).ToArray());

            throw new ValidationException(errors);
        }
        
        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            QrCode = dto.QrCode,
            Major = dto.Major,
            HashPassword = BCrypt.Net.BCrypt.HashPassword(dto.Password),
            Role = dto.Role,
            Created = DateTime.UtcNow
        };

        await _userRepository.AddAsync(user);

        return user;
    }

    public async Task<UserDto?> GetById(Guid id)
    {
        if (_currentUser.GetRole() != UserRole.Employee && _currentUser.GetUserId() != id)
        {
            throw new BadRequestException("Вам не доступна информация об этом пользователе");
        }
        
        var user = await _userRepository.GetByIdAsync(id);

        if (user == null)
        {
            throw new NotFoundException("Пользователя не существует");
        }

        return user.ToDto();
    }

    public async Task<UserAchievmentsDto> GetAchievmentsByUserId(Guid id)
    {
        if (_currentUser.GetRole() != UserRole.Employee && _currentUser.GetUserId() != id)
        {
            throw new BadRequestException("Вам не доступна информация об этом пользователе");
        }

        var user = await _userRepository.GetByIdAsync(id);

        if (user == null)
        {
            throw new NotFoundException("Пользователя не существует");
        }

        var achievments = await _userRepository.GetAchievmentsByUserIdAsync(id);

        return new UserAchievmentsDto
        {
            UserId = id,
            Achievments = achievments.ToDto()
        };
    }

    public async Task<UserLikedEventsDto> GetLikedEventsByUserId(Guid id)
    {
        if (_currentUser.GetRole() != UserRole.Employee && _currentUser.GetUserId() != id)
        {
            throw new BadRequestException("Вам не доступна информация об этом пользователе");
        }

        var user = await _userRepository.GetByIdAsync(id);

        if (user == null)
        {
            throw new NotFoundException("Пользователя не существует");
        }

        var likedEvents = await _userRepository.GetLikedEventsByUserIdAsync(id);

        return new UserLikedEventsDto
        {
            UserId = id,
            LikedEvents = likedEvents.Select(e => e.ToDto()).ToArray()
        };
    }

    public async Task<UserDto?> GetMyself()
    {
        var userId = _currentUser.GetUserId();
        var user = await GetById(userId);
        return user;
    }
    
    public async Task<PagedResponse<UserDto>> GetAllAsync(PagedRequest query)
    {
        var validationResult = await _pagedRequestValidator.ValidateAsync(query);

        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors
                .GroupBy(e => e.PropertyName)
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(e => e.ErrorMessage).ToArray());

            throw new ValidationException(errors);
        }
        
        var (users, totalCount) = await _userRepository.GetAllAsync(
            query.Page,
            query.PageSize,
            query.SortBy,
            query.Ascending);

        var enumerable = users as User[] ?? users.ToArray();
        
        if (enumerable.Length == 0)
        {
            throw new NotFoundException("Пользователей не найдено");
        }
        
        return new PagedResponse<UserDto>
        {
            Page = query.Page,
            PageSize = query.PageSize,
            TotalCount = totalCount,
            Items = enumerable.Select(u => u.ToDto()).ToArray()
        };
    }
}