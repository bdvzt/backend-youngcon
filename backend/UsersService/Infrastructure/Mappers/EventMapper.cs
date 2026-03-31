using UsersService.Domain.Entities;
using UsersService.DTOs.Events;

namespace UsersService.Infrastructure.Mappers;

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
            EventType = eventik.EventType,
            IsLive = eventik.IsLive,
            ZoneId = eventik.ZoneId,
            Speaker = eventik.Speaker
        };
    }
}