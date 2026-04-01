using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.Infrastructure.Repositories;

namespace YoungConService.Repositories.Events;

public class ConEventRepository(YoungConDbContext db) : IConEventRepository
{
    public async Task<Event?> GetByIdAsync(Guid id)
        => await db.Events
            .Include(e => e.Zone)
            .Include(e => e.Festival)
            .Include(e => e.Speaker)
            .FirstOrDefaultAsync(e => e.Id == id);

    public async Task<IEnumerable<Event>> GetAllAsync()
        => await db.Events
            .Include(e => e.Zone)
            .Include(e => e.Festival)
            .Include(e => e.Speaker)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();

    public async Task<IEnumerable<Event>> GetByFestivalIdAsync(Guid festivalId)
        => await db.Events
            .Where(e => e.FestivalId == festivalId)
            .Include(e => e.Zone)
            .Include(e => e.Speaker)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();

    public async Task<IEnumerable<Event>> GetByZoneIdAsync(Guid zoneId)
        => await db.Events
            .Where(e => e.ZoneId == zoneId)
            .Include(e => e.Festival)
            .Include(e => e.Speaker)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();

    public async Task<IEnumerable<Event>> GetBySpeakerIdAsync(Guid speakerId)
        => await db.Events
            .Where(e => e.Speaker != null && e.Speaker.Id == speakerId)
            .Include(e => e.Zone)
            .Include(e => e.Festival)
            .Include(e => e.Speaker)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();

    public async Task<Event> CreateAsync(Event @event)
    {
        db.Events.Add(@event);
        await db.SaveChangesAsync();
        return @event;
    }

    public async Task<Event?> UpdateAsync(Event @event)
    {
        var existing = await db.Events.FindAsync(@event.Id);
        if (existing == null) return null;
        db.Entry(existing).CurrentValues.SetValues(@event);
        await db.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var @event = await db.Events.FindAsync(id);
        if (@event == null) return false;
        db.Events.Remove(@event);
        await db.SaveChangesAsync();
        return true;
    }
}

