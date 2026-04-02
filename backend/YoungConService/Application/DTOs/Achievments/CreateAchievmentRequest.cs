using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Achievments;

public class CreateAchievmentRequest
{
    [Required(ErrorMessage = "Название ачивки обязательно")]
    [MaxLength(200, ErrorMessage = "Название ачивки не должно превышать 200 символов")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Описание ачивки обязательно")]
    [MaxLength(1000, ErrorMessage = "Описание ачивки не должно превышать 1000 символов")]
    public required string Description { get; set; }

    [Required(ErrorMessage = "Иконка обязательна")]
    [MaxLength(100, ErrorMessage = "Иконка не должна превышать 100 символов")]
    public required string Icon { get; set; }

    [Required(ErrorMessage = "Цвет обязателен")]
    [MaxLength(20, ErrorMessage = "Цвет не должен превышать 20 символов")]
    public required string Color { get; set; }
}

