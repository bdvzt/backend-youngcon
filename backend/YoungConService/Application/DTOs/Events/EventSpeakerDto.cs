namespace YoungConService.DTOs.Events;

public class EventSpeakerDTO
{
    public required Guid Id { get; set; }
    public required string FullName { get; set; }
    public required string Job { get; set; }
    public required string AvatarURL { get; set; }
}

