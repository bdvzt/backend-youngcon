namespace UsersService.DTOs.Events;

public class SpeakerDTO
{
    public required Guid Id { get; set; }
    public required string Name { get; set; } 
    public required string LastName { get; set; } 
    public required string Job { get; set; }
    public required string Bio { get; set; }
}