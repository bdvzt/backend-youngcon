using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Achievments;

public class CreateAchievmentRequest
{
    [Required(ErrorMessage = "Название ачивки обязательно")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Описание ачивки обязательно")]
    public required string Description { get; set; }

    [Required(ErrorMessage = "Иконка обязательна")]
    public required string Icon { get; set; }

    [Required(ErrorMessage = "Цвет обязателен")]
    public required string Color { get; set; }
}

