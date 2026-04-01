using Microsoft.EntityFrameworkCore;
using UsersService.Domain.Entities;
using UsersService.Infrastructure.Repositories;

namespace UsersService.Repositories.Events;

public class EventRepository(EventDbContext db) : IEventRepository
{
    // Festival methods
    public async Task<Festival?> GetFestivalByIdAsync(Guid id)
    {
        return await db.Festivals
            .FirstOrDefaultAsync(f => f.Id == id);
    }
    
    public async Task<IEnumerable<Festival>> GetAllFestivalsAsync()
    {
        return await db.Festivals
            .OrderBy(f => f.StartDateTime)
            .ToListAsync();
    }

    // Event methods
    public async Task<Event?> GetEventByIdAsync(Guid id)
    {
        return await db.Events
            .Include(e => e.Zone)
            .Include(e => e.Festival)
            .Include(e => e.Speaker)
            .FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<IEnumerable<Event>> GetEventsByFestivalIdAsync(Guid festivalId)
    {
        return await db.Events
            .Where(e => e.FestivalId == festivalId)
            .Include(e => e.Zone)
            .Include(e => e.Speaker)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();
    }

    public async Task<IEnumerable<Event>> GetEventsByZoneIdAsync(Guid zoneId)
    {
        return await db.Events
            .Where(e => e.ZoneId == zoneId)
            .Include(e => e.Festival)
            .Include(e => e.Speaker)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();
    }

    public async Task<IEnumerable<Event>> GetEventsBySpeakerIdAsync(Guid speakerId)
    {
        return await db.Events
            .Where(e => e.Speaker != null && e.Speaker.Id == speakerId)
            .Include(e => e.Zone)
            .Include(e => e.Festival)
            .Include(e => e.Speaker)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();
    }

    public async Task<IEnumerable<Event>> GetAllEventsAsync()
    {
        return await db.Events
            .Include(e => e.Zone)
            .Include(e => e.Festival)
            .Include(e => e.Speaker)
            .OrderBy(e => e.StartDateTime)
            .ToListAsync();
    }

    // Floor methods
    public async Task<Floor?> GetFloorByIdAsync(Guid id)
    {
        return await db.Floors
            .Include(f => f.Zones)
            .FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task<IEnumerable<Floor>> GetAllFloorsAsync()
    {
        return await db.Floors
            .Include(f => f.Zones)
            .OrderBy(f => f.Title)
            .ToListAsync();
    }

    // Zone methods
    public async Task<Zone?> GetZoneByIdAsync(Guid id)
    {
        return await db.Zones
            .Include(z => z.Floor)
            .Include(z => z.Events)
            .FirstOrDefaultAsync(z => z.Id == id);
    }

    public async Task<IEnumerable<Zone>> GetZonesByFloorIdAsync(Guid floorId)
    {
        return await db.Zones
            .Where(z => z.FloorId == floorId)
            .Include(z => z.Events)
            .OrderBy(z => z.Title)
            .ToListAsync();
    }

    public async Task<IEnumerable<Zone>> GetAllZonesAsync()
    {
        return await db.Zones
            .Include(z => z.Floor)
            .Include(z => z.Events)
            .OrderBy(z => z.Title)
            .ToListAsync();
    }

    // Speaker methods
    public async Task<Speaker?> GetSpeakerByIdAsync(Guid id)
    {
        return await db.Speakers
            .Include(s => s.Events)
            .FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<IEnumerable<Speaker>> GetAllSpeakersAsync()
    {
        return await db.Speakers
            .Include(s => s.Events)
            .OrderBy(s => s.Name)
            .ThenBy(s => s.LastName)
            .ToListAsync();
    }
}