using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Zones;

public class UpdateZoneRequest
{
    public Guid? FloorId { get; set; }
    
    [MinLength(2, ErrorMessage = "Название должно быть не менее 2 символов")]
    [MaxLength(100, ErrorMessage = "Название не может быть длиннее 100 символов")]
    public string? Title { get; set; }
    
    [MinLength(5, ErrorMessage = "Описание должно быть не менее 5 символов")]
    [MaxLength(500, ErrorMessage = "Описание не может быть длиннее 500 символов")]
    public string? Description { get; set; }
    public required double CoordX { get; set; }
    public required double CoordY { get; set; }
    
    [MinLength(1, ErrorMessage = "Иконка должна быть не менее 1 символа")]
    public string? Icon { get; set; }
    
    [RegularExpression("^#[0-9A-Fa-f]{6}$", ErrorMessage = "Цвет должен быть в формате #RRGGBB")]
    public string? Color { get; set; }
}
