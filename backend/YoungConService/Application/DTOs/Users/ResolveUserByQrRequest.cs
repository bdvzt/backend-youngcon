using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Users;

public class ResolveUserByQrRequest
{
    [Required(ErrorMessage = "QR код обязателен")]
    public required string QrCode { get; set; }
}

