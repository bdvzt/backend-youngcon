using YoungConService.Domain.Entities;
using YoungConService.DTOs.Events;

namespace YoungConService.Infrastructure.Mappers;

public static class EventMapper
{
    public static EventDTO ToDto(this Event eventik)
    {
        return new EventDTO()
        {
            Id = eventik.Id,
            Title = eventik.Title,
            Description = eventik.Description,
            StartDateTime = eventik.StartDateTime,
            EndDateTime = eventik.EndDateTime,
            Category = eventik.Category,
            ZoneId = eventik.ZoneId,
            FestivalId = eventik.FestivalId
        };
    }

    public static EventSpeakerDTO ToEventSpeakerDto(this Speaker speaker)
    {
        return new EventSpeakerDTO
        {
            Id = speaker.Id,
            FullName = speaker.FullName,
            Job = speaker.Job,
            AvatarURL = speaker.AvatarURL
        };
    }
}