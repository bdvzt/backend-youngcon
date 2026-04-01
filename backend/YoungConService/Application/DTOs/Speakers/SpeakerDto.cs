namespace YoungConService.DTOs.Speakers;

public class SpeakerDTO
{
    public required Guid Id { get; set; }
    public required string FullName { get; set; } 
    public required string Job { get; set; }
    public required string Bio { get; set; }
    public required string AvatarURL { get; set; }
}