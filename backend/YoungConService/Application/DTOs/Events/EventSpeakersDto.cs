namespace YoungConService.DTOs.Events;

public class EventSpeakersDTO
{
    public required Guid EventId { get; set; }
    public required EventSpeakerDTO[] Speakers { get; set; }
}

