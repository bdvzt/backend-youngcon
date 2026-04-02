using YoungConService.DTOs.Events;

namespace YoungConService.DTOs.Users;

public class UserLikedEventsDto
{
    public required Guid UserId { get; set; }
    public required EventDTO[] LikedEvents { get; set; }
}

