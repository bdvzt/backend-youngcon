using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.Infrastructure.Repositories;

namespace YoungConService.Repositories.Events;

public class FestivalRepository(YoungConDbContext db) : IFestivalRepository
{
    public async Task<Festival?> GetByIdAsync(Guid id)
        => await db.Festivals.FirstOrDefaultAsync(f => f.Id == id);

    public async Task<Festival?> GetLastAsync()
    {
        return await db.Festivals
            .OrderByDescending(f => f.StartDateTime)
            .FirstOrDefaultAsync();
    }
    
    public async Task<IEnumerable<Festival>> GetAllAsync()
        => await db.Festivals.OrderBy(f => f.StartDateTime).ToListAsync();

    public async Task<Festival> CreateAsync(Festival festival)
    {
        if (festival.Id == Guid.Empty)
        {
            festival.Id = Guid.NewGuid();
        }

        db.Festivals.Add(festival);
        await db.SaveChangesAsync();
        return festival;
    }

    public async Task<Festival?> UpdateAsync(Festival festival)
    {
        var existing = await db.Festivals.FindAsync(festival.Id);
        if (existing == null) return null;
        db.Entry(existing).CurrentValues.SetValues(festival);
        await db.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var festival = await db.Festivals.FindAsync(id);
        if (festival == null) return false;
        db.Festivals.Remove(festival);
        await db.SaveChangesAsync();
        return true;
    }
}

