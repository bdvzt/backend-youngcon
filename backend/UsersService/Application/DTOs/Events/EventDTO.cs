using UsersService.Domain.Entities;
using UsersService.Domain.Enums;

namespace UsersService.DTOs.Events;

public class EventDTO
{
    public required Guid Id { get; set; }
    public required string Title { get; set; } 
    public required string Description { get; set; } 
    public required DateTime StartDateTime { get; set; }
    public required DateTime EndDateTime { get; set; }
    public required EventType EventType { get; set; }
    public required Boolean IsLive { get; set; }
    public required Guid ZoneId { get; set; }
    public Speaker Speaker { get; set; }
}