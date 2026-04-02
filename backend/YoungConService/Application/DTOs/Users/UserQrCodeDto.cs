namespace YoungConService.DTOs.Users;

public class UserQrCodeDto
{
    public required Guid UserId { get; set; }
    public required string QrCode { get; set; }
}

