namespace YoungConService.DTOs.Users;

public class UserQrLookupDto
{
    public required Guid UserId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string QrCode { get; set; }
}

