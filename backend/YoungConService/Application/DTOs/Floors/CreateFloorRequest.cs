using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Floors;

public class CreateFloorRequest
{
    [Required(ErrorMessage = "Название этажа обязательно")]
    [MinLength(2, ErrorMessage = "Название должно быть не менее 2 символов")]
    [MaxLength(100, ErrorMessage = "Название не может быть длиннее 100 символов")]
    public required string Title { get; set; }
    
    [Required(ErrorMessage = "URL карты обязателен")]
    [Url(ErrorMessage = "Некорректный формат URL")]
    [MaxLength(500, ErrorMessage = "URL не может быть длиннее 500 символов")]
    public required string MapURL { get; set; }
}

