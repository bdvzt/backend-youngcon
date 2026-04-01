using YoungConService.Domain.Entities;
using YoungConService.DTOs.Events;
using YoungConService.DTOs.Speakers;

namespace YoungConService.Infrastructure.Mappers;

public static class SpeakerMapper
{
    public static SpeakerDTO ToDto(this Speaker speaker)
    {
        return new SpeakerDTO()
        {
            Id = speaker.Id,
            FullName = speaker.FullName,
            Job = speaker.Job,
            Bio = speaker.Bio,
            AvatarURL = speaker.AvatarURL
        };
    }
}