using YoungConService.DTOs.Events;

namespace YoungConService.Services.Events.Event;

public interface IEventService
{
    Task<EventDTO?> GetByIdAsync(Guid id);
    Task<IEnumerable<EventDTO>> GetAllAsync();
    Task<IEnumerable<EventDTO>> GetByFestivalIdAsync(Guid festivalId);
    Task<IEnumerable<EventDTO>> GetByZoneIdAsync(Guid zoneId);
    Task<IEnumerable<EventDTO>> GetBySpeakerIdAsync(Guid speakerId);
    Task<EventDTO> CreateAsync(CreateEventRequest request);
    Task<EventDTO?> UpdateAsync(Guid id, UpdateEventRequest request);
    Task<bool> DeleteAsync(Guid id);
}

