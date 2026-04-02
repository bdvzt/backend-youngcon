namespace YoungConService.DTOs.Events;

public class EventLikeDTO
{
    public required Guid EventId { get; set; }
    public required Guid UserId { get; set; }
    public required bool IsLiked { get; set; }
}

