using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.Infrastructure.Repositories;

namespace YoungConService.Repositories.Events;

public class FloorRepository(YoungConDbContext db) : IFloorRepository
{
    public async Task<Floor?> GetByIdAsync(Guid id)
        => await db.Floors.Include(f => f.Zones).FirstOrDefaultAsync(f => f.Id == id);

    public async Task<IEnumerable<Floor>> GetAllAsync()
        => await db.Floors.Include(f => f.Zones).OrderBy(f => f.Title).ToListAsync();

    public async Task<Floor> CreateAsync(Floor floor)
    {
        db.Floors.Add(floor);
        await db.SaveChangesAsync();
        return floor;
    }

    public async Task<Floor?> UpdateAsync(Floor floor)
    {
        var existing = await db.Floors.FindAsync(floor.Id);
        if (existing == null) return null;
        db.Entry(existing).CurrentValues.SetValues(floor);
        await db.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var floor = await db.Floors.FindAsync(id);
        if (floor == null) return false;
        db.Floors.Remove(floor);
        await db.SaveChangesAsync();
        return true;
    }
}

