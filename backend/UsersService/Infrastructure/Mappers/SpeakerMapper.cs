using UsersService.Domain.Entities;
using UsersService.DTOs.Events;

namespace UsersService.Infrastructure.Mappers;

public static class SpeakerMapper
{
    public static SpeakerDTO ToDto(this Speaker speaker)
    {
        return new SpeakerDTO()
        {
            Id = speaker.Id,
            Name = speaker.Name,
            LastName = speaker.LastName,
            Job = speaker.Job,
            Bio = speaker.Bio
        };
    }
}