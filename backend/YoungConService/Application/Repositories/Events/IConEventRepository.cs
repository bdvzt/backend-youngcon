using YoungConService.Domain.Entities;

namespace YoungConService.Repositories.Events;

public interface IConEventRepository
{
    Task<Event?> GetByIdAsync(Guid id);
    Task<IEnumerable<Event>> GetAllAsync();
    Task<IEnumerable<Event>> GetByFestivalIdAsync(Guid festivalId);
    Task<IEnumerable<Event>> GetByZoneIdAsync(Guid zoneId);
    Task<IEnumerable<Event>> GetBySpeakerIdAsync(Guid speakerId);
    Task<Event> CreateAsync(Event @event);
    Task<Event?> UpdateAsync(Event @event);
    Task<bool> DeleteAsync(Guid id);
}

