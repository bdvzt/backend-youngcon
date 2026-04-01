using UsersService.Domain.Entities;
using UsersService.DTOs.Events;

namespace UsersService.Services.Events;

public interface IEventService
{
    // Festival methods
    Task<FestivalDTO?> GetFestivalByIdAsync(Guid id);
    Task<IEnumerable<FestivalDTO>> GetAllFestivalsAsync();
    
    // Event methods
    Task<EventDTO?> GetEventByIdAsync(Guid id);
    Task<IEnumerable<EventDTO>> GetEventsByFestivalIdAsync(Guid festivalId);
    Task<IEnumerable<EventDTO>> GetEventsByZoneIdAsync(Guid zoneId);
    Task<IEnumerable<EventDTO>> GetEventsBySpeakerIdAsync(Guid speakerId);
    Task<IEnumerable<EventDTO>> GetAllEventsAsync();
    
    // Floor methods
    Task<FloorDTO?> GetFloorByIdAsync(Guid id);
    Task<IEnumerable<FloorDTO>> GetAllFloorsAsync();
    
    // Zone methods
    Task<ZoneDTO?> GetZoneByIdAsync(Guid id);
    Task<IEnumerable<ZoneDTO>> GetZonesByFloorIdAsync(Guid floorId);
    Task<IEnumerable<ZoneDTO>> GetAllZonesAsync();
    
    // Speaker methods
    Task<SpeakerDTO?> GetSpeakerByIdAsync(Guid id);
    Task<IEnumerable<SpeakerDTO>> GetAllSpeakersAsync();
}

