using YoungConService.DTOs.Events;
using YoungConService.Infrastructure.Mappers;
using YoungConService.Repositories.Events;

namespace YoungConService.Services.Events.Event;

public class EventService(IConEventRepository repository, ISpeakerRepository speakerRepository) : IEventService
{
    public async Task<EventDTO?> GetByIdAsync(Guid id)
    {
        var entity = await repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<IEnumerable<EventDTO>> GetAllAsync()
        => (await repository.GetAllAsync()).Select(e => e.ToDto());

    public async Task<IEnumerable<EventDTO>> GetByFestivalIdAsync(Guid festivalId)
        => (await repository.GetByFestivalIdAsync(festivalId)).Select(e => e.ToDto());

    public async Task<IEnumerable<EventDTO>> GetByZoneIdAsync(Guid zoneId)
        => (await repository.GetByZoneIdAsync(zoneId)).Select(e => e.ToDto());

    public async Task<IEnumerable<EventDTO>> GetBySpeakerIdAsync(Guid speakerId)
        => (await repository.GetBySpeakerIdAsync(speakerId)).Select(e => e.ToDto());

    public async Task<EventDTO> CreateAsync(CreateEventRequest request)
    {
        YoungConService.Domain.Entities.Speaker? speaker = null;
        if (request.SpeakerId.HasValue)
        {
            speaker = await speakerRepository.GetByIdAsync(request.SpeakerId.Value);
        }

        var entity = new YoungConService.Domain.Entities.Event
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Description = request.Description,
            StartDateTime = request.StartDateTime,
            EndDateTime = request.EndDateTime,
            Category = request.Category,
            ZoneId = request.ZoneId,
            FestivalId = request.FestivalId,
            Speaker = speaker,
            SpeakerId = speaker?.Id
        };

        var created = await repository.CreateAsync(entity);
        return created.ToDto();
    }

    public async Task<EventDTO?> UpdateAsync(Guid id, UpdateEventRequest request)
    {
        var existing = await repository.GetByIdAsync(id);
        if (existing == null) return null;

        if (request.Title != null) existing.Title = request.Title;
        if (request.Description != null) existing.Description = request.Description;
        if (request.StartDateTime.HasValue) existing.StartDateTime = request.StartDateTime.Value;
        if (request.EndDateTime.HasValue) existing.EndDateTime = request.EndDateTime.Value;
        if (request.Category != null) existing.Category = request.Category;
        if (request.ZoneId.HasValue) existing.ZoneId = request.ZoneId.Value;
        if (request.FestivalId.HasValue) existing.FestivalId = request.FestivalId.Value;

        if (request.SpeakerId.HasValue)
        {
            var speaker = await speakerRepository.GetByIdAsync(request.SpeakerId.Value);
            existing.Speaker = speaker;
            existing.SpeakerId = speaker?.Id;
        }

        var updated = await repository.UpdateAsync(existing);
        return updated?.ToDto();
    }

    public Task<bool> DeleteAsync(Guid id) => repository.DeleteAsync(id);
}
