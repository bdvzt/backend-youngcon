using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.Infrastructure.Repositories;

namespace YoungConService.Repositories.Events;

public class ZoneRepository(YoungConDbContext db) : IZoneRepository
{
    public async Task<Zone?> GetByIdAsync(Guid id)
        => await db.Zones
            .Include(z => z.Floor)
            .FirstOrDefaultAsync(z => z.Id == id);

    public async Task<IEnumerable<Zone>> GetAllAsync()
        => await db.Zones
            .Include(z => z.Floor)
            .OrderBy(z => z.Title)
            .ToListAsync();

    public async Task<IEnumerable<Zone>> GetByFloorIdAsync(Guid floorId)
        => await db.Zones
            .Where(z => z.FloorId == floorId)
            .OrderBy(z => z.Title)
            .ToListAsync();

    public async Task<Zone> CreateAsync(Zone zone)
    {
        db.Zones.Add(zone);
        await db.SaveChangesAsync();
        return zone;
    }

    public async Task<Zone?> UpdateAsync(Zone zone)
    {
        var existing = await db.Zones.FindAsync(zone.Id);
        if (existing == null) return null;
        db.Entry(existing).CurrentValues.SetValues(zone);
        await db.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var zone = await db.Zones.FindAsync(id);
        if (zone == null) return false;
        db.Zones.Remove(zone);
        await db.SaveChangesAsync();
        return true;
    }
}

