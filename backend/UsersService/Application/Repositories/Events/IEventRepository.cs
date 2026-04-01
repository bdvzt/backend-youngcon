using UsersService.Domain.Entities;
using UsersService.DTOs.Events;

namespace UsersService.Repositories.Events;

public interface IEventRepository
{
    // Festival methods
    Task<Festival?> GetFestivalByIdAsync(Guid id);
    Task<IEnumerable<Festival>> GetAllFestivalsAsync();
    
    // Event methods
    Task<Event?> GetEventByIdAsync(Guid id);
    Task<IEnumerable<Event>> GetEventsByFestivalIdAsync(Guid festivalId);
    Task<IEnumerable<Event>> GetEventsByZoneIdAsync(Guid zoneId);
    Task<IEnumerable<Event>> GetEventsBySpeakerIdAsync(Guid speakerId);
    Task<IEnumerable<Event>> GetAllEventsAsync();
    
    // Floor methods
    Task<Floor?> GetFloorByIdAsync(Guid id);
    Task<IEnumerable<Floor>> GetAllFloorsAsync();
    
    // Zone methods
    Task<Zone?> GetZoneByIdAsync(Guid id);
    Task<IEnumerable<Zone>> GetZonesByFloorIdAsync(Guid floorId);
    Task<IEnumerable<Zone>> GetAllZonesAsync();
    
    // Speaker methods
    Task<Speaker?> GetSpeakerByIdAsync(Guid id);
    Task<IEnumerable<Speaker>> GetAllSpeakersAsync();
}