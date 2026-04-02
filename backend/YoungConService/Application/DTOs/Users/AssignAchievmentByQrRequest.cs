using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Users;

public class AssignAchievmentByQrRequest
{
    [Required(ErrorMessage = "QR код обязателен")]
    public required string QrCode { get; set; }

    [Required(ErrorMessage = "Идентификатор ачивки обязателен")]
    public required Guid AchievmentId { get; set; }
}

