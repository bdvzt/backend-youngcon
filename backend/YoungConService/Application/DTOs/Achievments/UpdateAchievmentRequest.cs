using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Achievments;

public class UpdateAchievmentRequest
{
    [MaxLength(200, ErrorMessage = "Название ачивки не должно превышать 200 символов")]
    public string? Name { get; set; }

    [MaxLength(1000, ErrorMessage = "Описание ачивки не должно превышать 1000 символов")]
    public string? Description { get; set; }

    [MaxLength(100, ErrorMessage = "Иконка не должна превышать 100 символов")]
    public string? Icon { get; set; }

    [MaxLength(20, ErrorMessage = "Цвет не должен превышать 20 символов")]
    public string? Color { get; set; }
}

