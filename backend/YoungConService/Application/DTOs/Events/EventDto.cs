namespace YoungConService.DTOs.Events;
public class EventDTO
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateTime StartDateTime { get; set; }
    public required DateTime EndDateTime { get; set; }
    public required string Category { get; set; }
    public required Guid ZoneId { get; set; }
    public required Guid FestivalId { get; set; }
}
