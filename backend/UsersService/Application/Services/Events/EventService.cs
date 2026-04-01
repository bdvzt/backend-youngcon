using UsersService.Domain.Entities;
using UsersService.DTOs.Events;
using UsersService.Repositories.Events;

namespace UsersService.Services.Events;

public class EventService(IEventRepository eventRepository) : IEventService
{
    // Festival methods
    public async Task<FestivalDTO?> GetFestivalByIdAsync(Guid id)
    {
        var festival = await eventRepository.GetFestivalByIdAsync(id);
        return festival == null ? null : MapToFestivalDto(festival);
    }
    
    public async Task<IEnumerable<FestivalDTO>> GetAllFestivalsAsync()
    {
        var festivals = await eventRepository.GetAllFestivalsAsync();
        return festivals.Select(MapToFestivalDto);
    }

    // Event methods
    public async Task<EventDTO?> GetEventByIdAsync(Guid id)
    {
        var @event = await eventRepository.GetEventByIdAsync(id);
        return @event == null ? null : MapToEventDto(@event);
    }

    public async Task<IEnumerable<EventDTO>> GetEventsByFestivalIdAsync(Guid festivalId)
    {
        var events = await eventRepository.GetEventsByFestivalIdAsync(festivalId);
        return events.Select(MapToEventDto);
    }

    public async Task<IEnumerable<EventDTO>> GetEventsByZoneIdAsync(Guid zoneId)
    {
        var events = await eventRepository.GetEventsByZoneIdAsync(zoneId);
        return events.Select(MapToEventDto);
    }

    public async Task<IEnumerable<EventDTO>> GetEventsBySpeakerIdAsync(Guid speakerId)
    {
        var events = await eventRepository.GetEventsBySpeakerIdAsync(speakerId);
        return events.Select(MapToEventDto);
    }

    public async Task<IEnumerable<EventDTO>> GetAllEventsAsync()
    {
        var events = await eventRepository.GetAllEventsAsync();
        return events.Select(MapToEventDto);
    }

    // Floor methods
    public async Task<FloorDTO?> GetFloorByIdAsync(Guid id)
    {
        var floor = await eventRepository.GetFloorByIdAsync(id);
        return floor == null ? null : MapToFloorDto(floor);
    }

    public async Task<IEnumerable<FloorDTO>> GetAllFloorsAsync()
    {
        var floors = await eventRepository.GetAllFloorsAsync();
        return floors.Select(MapToFloorDto);
    }

    // Zone methods
    public async Task<ZoneDTO?> GetZoneByIdAsync(Guid id)
    {
        var zone = await eventRepository.GetZoneByIdAsync(id);
        return zone == null ? null : MapToZoneDto(zone);
    }

    public async Task<IEnumerable<ZoneDTO>> GetZonesByFloorIdAsync(Guid floorId)
    {
        var zones = await eventRepository.GetZonesByFloorIdAsync(floorId);
        return zones.Select(MapToZoneDto);
    }

    public async Task<IEnumerable<ZoneDTO>> GetAllZonesAsync()
    {
        var zones = await eventRepository.GetAllZonesAsync();
        return zones.Select(MapToZoneDto);
    }

    // Speaker methods
    public async Task<SpeakerDTO?> GetSpeakerByIdAsync(Guid id)
    {
        var speaker = await eventRepository.GetSpeakerByIdAsync(id);
        return speaker == null ? null : MapToSpeakerDto(speaker);
    }

    public async Task<IEnumerable<SpeakerDTO>> GetAllSpeakersAsync()
    {
        var speakers = await eventRepository.GetAllSpeakersAsync();
        return speakers.Select(MapToSpeakerDto);
    }

    // Mapping methods
    private static FestivalDTO MapToFestivalDto(Festival festival) => new()
    {
        Id = festival.Id,
        Title = festival.Title,
        Description = festival.Description,
        StartDateTime = festival.StartDateTime,
        EndDateTime = festival.EndDateTime
    };

    private static EventDTO MapToEventDto(Event @event) => new()
    {
        Id = @event.Id,
        Title = @event.Title,
        Description = @event.Description,
        StartDateTime = @event.StartDateTime,
        EndDateTime = @event.EndDateTime,
        EventType = @event.EventType,
        IsLive = @event.IsLive,
        ZoneId = @event.ZoneId,
        FestivalId = @event.FestivalId,
        Speaker = @event.Speaker != null ? MapToSpeakerDto(@event.Speaker) : null
    };

    private static FloorDTO MapToFloorDto(Floor floor) => new()
    {
        Id = floor.Id,
        Title = floor.Title,
        Description = floor.Description,
        MapURL = floor.MapURL
    };

    private static ZoneDTO MapToZoneDto(Zone zone) => new()
    {
        Id = zone.Id,
        FloorId = zone.FloorId,
        Title = zone.Title,
        Description = zone.Description
    };

    private static SpeakerDTO MapToSpeakerDto(Speaker speaker) => new()
    {
        Id = speaker.Id,
        Name = speaker.Name,
        LastName = speaker.LastName,
        Job = speaker.Job,
        Bio = speaker.Bio
    };
}

