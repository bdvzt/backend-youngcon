using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Zones;

public class CreateZoneRequest
{
    [Required(ErrorMessage = "FloorId обязателен")]
    public required Guid FloorId { get; set; }
    
    [Required(ErrorMessage = "Название зоны обязательно")]
    [MinLength(2, ErrorMessage = "Название должно быть не менее 2 символов")]
    [MaxLength(100, ErrorMessage = "Название не может быть длиннее 100 символов")]
    public required string Title { get; set; }
    
    [Required(ErrorMessage = "Описание обязательно")]
    [MinLength(5, ErrorMessage = "Описание должно быть не менее 5 символов")]
    [MaxLength(500, ErrorMessage = "Описание не может быть длиннее 500 символов")]
    public required string Description { get; set; }
    
    public required string CoordX { get; set; }
    public required string CoordY { get; set; }
    
    [Required(ErrorMessage = "Иконка обязательна")]
    [MinLength(1, ErrorMessage = "Иконка должна быть не менее 1 символа")]
    [MaxLength(100, ErrorMessage = "Иконка не может быть длиннее 100 символов")]
    public required string Icon { get; set; }
    
    [Required(ErrorMessage = "Цвет обязателен")]
    [RegularExpression("^#[0-9A-Fa-f]{6}$", ErrorMessage = "Цвет должен быть в формате #RRGGBB")]
    public required string Color { get; set; }
}
