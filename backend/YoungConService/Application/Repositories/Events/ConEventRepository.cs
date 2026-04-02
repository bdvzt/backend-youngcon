using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.Infrastructure.Repositories;

namespace YoungConService.Repositories.Events;

public class ConEventRepository(YoungConDbContext db) : IConEventRepository
{
    public async Task<Event?> GetByIdAsync(Guid id)
        => await db.Events
            .Include(e => e.Speakers)
            .FirstOrDefaultAsync(e => e.Id == id);

    public async Task<IReadOnlyCollection<Speaker>> GetSpeakersByEventIdAsync(Guid eventId)
        => await db.Events
            .Where(e => e.Id == eventId)
            .SelectMany(e => e.Speakers)
            .OrderBy(s => s.FullName)
            .ToListAsync();

    public async Task<IEnumerable<Event>> GetAllAsync()
        => await db.Events
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();

    public async Task<IEnumerable<Event>> GetByFestivalIdAsync(Guid festivalId)
        => await db.Events
            .Where(e => e.FestivalId == festivalId)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();

    public async Task<IEnumerable<Event>> GetByZoneIdAsync(Guid zoneId)
        => await db.Events
            .Where(e => e.ZoneId == zoneId)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();

    public async Task<IEnumerable<Event>> GetBySpeakerIdAsync(Guid speakerId)
        => await db.Events
            .Where(e => e.Speakers.Any(s => s.Id == speakerId))
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
        var exists = await db.Events.AnyAsync(e => e.Id == @event.Id);
        if (!exists) return null;

        await db.SaveChangesAsync();
        return @event;
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

