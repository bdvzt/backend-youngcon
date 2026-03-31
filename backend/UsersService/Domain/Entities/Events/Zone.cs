namespace UsersService.Domain.Entities;

public class Zone
{
    public required Guid Id { get; set; }
    public required Guid FloorId { get; set; }
    public required string Title { get; set; } 
    public required string Description { get; set; } 
}