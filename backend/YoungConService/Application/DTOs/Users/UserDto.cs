using YoungConService.Domain.Enums;

namespace YoungConService.DTOs.Users;

public class UserDto
{
    public required Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; } 
    public required string QrCode { get; set; }
    public Major Major { get; set; }
    public UserRole Role { get; set; }
}