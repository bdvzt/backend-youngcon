using YoungConService.Domain.Entities;
using YoungConService.DTOs;
using YoungConService.DTOs.Users;

namespace YoungConService.Services;

public interface IUserService
{
    Task<User> CreateUserAsync(CreateUserRequest dto);
    Task<UserDto?> GetById(Guid id);
    Task<UserAchievmentsDto> GetAchievmentsByUserId(Guid id);
    Task<UserLikedEventsDto> GetLikedEventsByUserId(Guid id);
    Task<UserDto?> GetMyself();
    Task<PagedResponse<UserDto>> GetAllAsync(PagedRequest pagedRequest);
}