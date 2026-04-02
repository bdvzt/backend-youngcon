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

    private async Task<string> GenerateUniqueQrCodeAsync()
    {
        while (true)
        {
            var candidate = $"YC-{Guid.NewGuid():N}";
            var existing = await _userRepository.GetByQrCodeAsync(candidate);
            if (existing == null)
            {
                return candidate;
            }
        }
    }

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
        
        var qrCode = string.IsNullOrWhiteSpace(dto.QrCode)
            ? await GenerateUniqueQrCodeAsync()
            : dto.QrCode.Trim();

        if (!string.IsNullOrWhiteSpace(dto.QrCode))
        {
            var existingByQr = await _userRepository.GetByQrCodeAsync(qrCode);
            if (existingByQr != null)
            {
                throw new BadRequestException("Пользователь с таким QR кодом уже существует");
            }
        }

        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            QrCode = qrCode,
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

    public async Task<UserQrLookupDto> ResolveUserByQrAsync(string qrCode)
    {
        if (_currentUser.GetRole() != UserRole.Employee)
        {
            throw new BadRequestException("Сканирование QR доступно только сотруднику");
        }

        if (string.IsNullOrWhiteSpace(qrCode))
        {
            throw new BadRequestException("QR код не может быть пустым");
        }

        var user = await _userRepository.GetByQrCodeAsync(qrCode.Trim());
        if (user == null)
        {
            throw new NotFoundException("Пользователь с таким QR кодом не найден");
        }

        return new UserQrLookupDto
        {
            UserId = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            QrCode = user.QrCode
        };
    }

    public async Task<AssignAchievmentByQrResultDto> AssignAchievmentByQrAsync(AssignAchievmentByQrRequest request)
    {
        if (_currentUser.GetRole() != UserRole.Employee)
        {
            throw new BadRequestException("Выдача ачивок по QR доступна только сотруднику");
        }

        var user = await _userRepository.GetByQrCodeAsync(request.QrCode.Trim());
        if (user == null)
        {
            throw new NotFoundException("Пользователь с таким QR кодом не найден");
        }

        var userWithAchievments = await _userRepository.GetByIdWithAchievmentsAsync(user.Id);
        if (userWithAchievments == null)
        {
            throw new NotFoundException("Пользователь не найден");
        }

        var achievment = await _userRepository.GetAchievmentByIdAsync(request.AchievmentId);
        if (achievment == null)
        {
            throw new NotFoundException("Ачивка не найдена");
        }

        var alreadyAssigned = userWithAchievments.Achievments.Any(a => a.Id == achievment.Id);
        if (!alreadyAssigned)
        {
            userWithAchievments.Achievments.Add(achievment);
            await _userRepository.UpdateAsync(userWithAchievments);
        }

        return new AssignAchievmentByQrResultDto
        {
            UserId = userWithAchievments.Id,
            AchievmentId = achievment.Id,
            AssignedNow = !alreadyAssigned
        };
    }

    public async Task<UserQrCodeDto> GetMyQrCodeAsync()
    {
        var userId = _currentUser.GetUserId();
        var user = await _userRepository.GetByIdAsync(userId);

        if (user == null)
        {
            throw new NotFoundException("Пользователь не найден");
        }

        return new UserQrCodeDto
        {
            UserId = user.Id,
            QrCode = user.QrCode
        };
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