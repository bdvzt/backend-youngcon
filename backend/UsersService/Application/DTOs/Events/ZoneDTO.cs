namespace UsersService.DTOs.Events;

public class ZoneDTO
{
    public required Guid Id { get; set; }
    public required Guid FloorId { get; set; }
    public required string Title { get; set; } 
    public required string Description { get; set; } 
}