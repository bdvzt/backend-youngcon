namespace UsersService.DTOs.Events;

public class FloorDTO
{
    public required Guid Id { get; set; }
    public required string Title { get; set; } 
    public required string Description { get; set; } 
    public required string MapURL { get; set; } 
}