namespace UsersService.DTOs.Events;

public class FestivalDTO
{
    public required string Title { get; set; } 
    public required string Description { get; set; } 
    public required DateTime StartDateTime { get; set; }
    public required DateTime EndDateTime { get; set; }
}