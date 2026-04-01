using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Floors;

public class UpdateFloorRequest
{
    [MinLength(2, ErrorMessage = "Название должно быть не менее 2 символов")]
    [MaxLength(100, ErrorMessage = "Название не может быть длиннее 100 символов")]
    public string? Title { get; set; }
    
    [Url(ErrorMessage = "Некорректный формат URL")]
    [MaxLength(500, ErrorMessage = "URL не может быть длиннее 500 символов")]
    public string? MapURL { get; set; }
}

