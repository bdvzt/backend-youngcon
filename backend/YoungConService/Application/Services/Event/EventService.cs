using YoungConService.DTOs.Events;
using YoungConService.Infrastructure.Auth;
using YoungConService.Infrastructure.Errors.Exceptions;
using YoungConService.Infrastructure.Mappers;
using YoungConService.Infrastructure.Repositories;
using YoungConService.Repositories.Events;

namespace YoungConService.Services.Events.Event;

public class EventService(
    IConEventRepository repository,
    ISpeakerRepository speakerRepository,
    IUserRepository userRepository,
    ICurrentUser currentUser) : IEventService
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly ICurrentUser _currentUser = currentUser;

    public async Task<EventDTO?> GetByIdAsync(Guid id)
    {
        var entity = await repository.GetByIdAsync(id);
        return entity?.ToDto();
    }

    public async Task<EventSpeakersDTO?> GetSpeakersByEventIdAsync(Guid eventId)
    {
        var entity = await repository.GetByIdAsync(eventId);
        if (entity == null)
        {
            return null;
        }

        var speakers = await repository.GetSpeakersByEventIdAsync(eventId);

        return new EventSpeakersDTO
        {
            EventId = eventId,
            Speakers = speakers.Select(s => s.ToEventSpeakerDto()).ToArray()
        };
    }

    public async Task<EventLikeDTO> ToggleLikeAsync(Guid eventId)
    {
        var userId = _currentUser.GetUserId();
        var user = await _userRepository.GetByIdWithLikedEventsAsync(userId);

        if (user == null)
        {
            throw new NotFoundException("Пользователь не найден");
        }

        var eventEntity = await repository.GetByIdAsync(eventId);
        if (eventEntity == null)
        {
            throw new NotFoundException("Событие не найдено");
        }

        var likedEvent = user.LikedEvents.FirstOrDefault(e => e.Id == eventId);
        var isLiked = likedEvent == null;

        if (isLiked)
        {
            user.LikedEvents.Add(eventEntity);
        }
        else
        {
            user.LikedEvents.Remove(likedEvent!);
        }

        await _userRepository.UpdateAsync(user);

        return new EventLikeDTO
        {
            EventId = eventId,
            UserId = userId,
            IsLiked = isLiked
        };
    }

    public async Task<IEnumerable<EventDTO>> GetByFestivalIdAsync(Guid festivalId)
        => (await repository.GetByFestivalIdAsync(festivalId)).Select(e => e.ToDto());

    public async Task<IEnumerable<EventDTO>> GetByZoneIdAsync(Guid zoneId)
        => (await repository.GetByZoneIdAsync(zoneId)).Select(e => e.ToDto());

    public async Task<IEnumerable<EventDTO>> GetBySpeakerIdAsync(Guid speakerId)
        => (await repository.GetBySpeakerIdAsync(speakerId)).Select(e => e.ToDto());

    public async Task<EventDTO> CreateAsync(CreateEventRequest request)
    {
        var speakerIds = request.SpeakerIds.Distinct().ToArray();
        var speakers = await speakerRepository.GetByIdsAsync(speakerIds);

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
            Speakers = speakers.ToArray()
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

        if (request.SpeakerIds != null)
        {
            var speakers = await speakerRepository.GetByIdsAsync(request.SpeakerIds);
            existing.Speakers = speakers.ToArray();
        }

        var updated = await repository.UpdateAsync(existing);
        return updated?.ToDto();
    }

    public Task<bool> DeleteAsync(Guid id) => repository.DeleteAsync(id);
}
