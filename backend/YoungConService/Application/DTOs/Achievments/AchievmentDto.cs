namespace YoungConService.DTOs.Achievments;

public class AchievmentDTO
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Icon { get; set; }
    public required string Color { get; set; }
}

