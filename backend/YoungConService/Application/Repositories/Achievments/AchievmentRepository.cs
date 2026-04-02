using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.Infrastructure.Repositories;

namespace YoungConService.Repositories.Achievments;

public class AchievmentRepository(YoungConDbContext db) : IAchievmentRepository
{
    public async Task<Achievment?> GetByIdAsync(Guid id)
        => await db.Achievments.FirstOrDefaultAsync(a => a.Id == id);

    public async Task<IEnumerable<Achievment>> GetAllAsync()
        => await db.Achievments.OrderBy(a => a.Name).ToListAsync();

    public async Task<Achievment> CreateAsync(Achievment achievment)
    {
        db.Achievments.Add(achievment);
        await db.SaveChangesAsync();
        return achievment;
    }

    public async Task<Achievment?> UpdateAsync(Achievment achievment)
    {
        var existing = await db.Achievments.FindAsync(achievment.Id);
        if (existing == null) return null;

        db.Entry(existing).CurrentValues.SetValues(achievment);
        await db.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var achievment = await db.Achievments.FindAsync(id);
        if (achievment == null) return false;

        db.Achievments.Remove(achievment);
        await db.SaveChangesAsync();
        return true;
    }
}

