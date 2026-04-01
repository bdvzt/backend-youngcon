namespace UsersService.Domain.Entities;

public class Festival
{
    public required Guid Id { get; set; }
    public required string Title { get; set; } 
    public required string Description { get; set; } 
    public required DateTime StartDateTime { get; set; }
    public required DateTime EndDateTime { get; set; }
    
    public ICollection<Event> Events { get; set; } = [];
}