using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.DTOs.Users;

namespace YoungConService.Infrastructure.Repositories;

public class UserRepository(YoungConDbContext db) : IUserRepository
{
    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await db.Users.FindAsync(id);
    }

    public async Task<User?> GetByIdWithLikedEventsAsync(Guid id)
    {
        return await db.Users
            .Include(u => u.LikedEvents)
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> GetByIdWithAchievmentsAsync(Guid id)
    {
        return await db.Users
            .Include(u => u.Achievments)
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> GetByQrCodeAsync(string qrCode)
    {
        return await db.Users.FirstOrDefaultAsync(u => u.QrCode == qrCode);
    }

    public async Task<Achievment?> GetAchievmentByIdAsync(Guid achievmentId)
    {
        return await db.Achievments.FirstOrDefaultAsync(a => a.Id == achievmentId);
    }
    
    public async Task<User?> GetByEmailAsync(string email)
    {
        return await db.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<IReadOnlyCollection<Achievment>> GetAchievmentsByUserIdAsync(Guid userId)
    {
        return await db.Users
            .Where(u => u.Id == userId)
            .SelectMany(u => u.Achievments)
            .ToListAsync();
    }

    public async Task<IReadOnlyCollection<Event>> GetLikedEventsByUserIdAsync(Guid userId)
    {
        return await db.Users
            .Where(u => u.Id == userId)
            .SelectMany(u => u.LikedEvents)
            .Include(e => e.Speakers)
            .ToListAsync();
    }

    public async Task<(IEnumerable<User> Users, int TotalCount)> GetAllAsync(
        int page, int pageSize, UserSortOption? sortBy = null, bool ascending = true)
    {
        IQueryable<User> query = db.Users;

        query = sortBy switch
        {
            UserSortOption.LastName => ascending ? query.OrderBy(u => u.LastName) : query.OrderByDescending(u => u.LastName),
            UserSortOption.Created => ascending ? query.OrderBy(u => u.Created) : query.OrderByDescending(u => u.Created),
            _ => query.OrderBy(u => u.Created)
        };

        var totalCount = await query.CountAsync();

        var users = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (users, totalCount);
    }

    public async Task AddAsync(User user)
    {
        db.Users.Add(user);
        await db.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        db.Users.Update(user);
        await db.SaveChangesAsync();
    }
}