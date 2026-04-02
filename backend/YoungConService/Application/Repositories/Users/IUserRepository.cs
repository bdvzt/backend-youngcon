using YoungConService.Domain.Entities;
using YoungConService.DTOs.Users;

namespace YoungConService.Infrastructure.Repositories;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id);
    Task<User?> GetByIdWithLikedEventsAsync(Guid id);
    Task<User?> GetByIdWithAchievmentsAsync(Guid id);
    Task<User?> GetByQrCodeAsync(string qrCode);
    Task<Achievment?> GetAchievmentByIdAsync(Guid achievmentId);
    Task<User?> GetByEmailAsync(string email);
    Task<IReadOnlyCollection<Achievment>> GetAchievmentsByUserIdAsync(Guid userId);
    Task<IReadOnlyCollection<Event>> GetLikedEventsByUserIdAsync(Guid userId);
    Task<(IEnumerable<User> Users, int TotalCount)> GetAllAsync(
        int page, 
        int pageSize, 
        UserSortOption? sortBy = null, 
        bool ascending = true);

    Task AddAsync(User user);
    Task UpdateAsync(User user);
}