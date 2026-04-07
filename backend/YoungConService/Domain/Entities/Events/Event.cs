using YoungConService.Domain.Enums;

namespace YoungConService.Domain.Entities;

public class Event
{
    public required Guid Id { get; set; }
    
    public required Guid ZoneId { get; set; }
    public required Guid FestivalId { get; set; }
    public required string Title { get; set; } 
    public required string Description { get; set; } 
    public required DateTime StartDateTime { get; set; }
    public required DateTime EndDateTime { get; set; }
    
    public required string Category { get; set; }
    public string? StreamURL { get; set; }
    public Zone Zone { get; set; } = null!;
    public Festival Festival { get; set; } = null!;
    public ICollection<Speaker> Speakers { get; set; } = [];
}