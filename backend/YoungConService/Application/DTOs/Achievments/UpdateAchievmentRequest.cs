using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Achievments;

public class UpdateAchievmentRequest
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public string? Color { get; set; }
}

