using UsersService.Domain.Enums;

namespace UsersService.DTOs;

public class CreateUserRequest
{ 
    public required string FirstName { get; set; }
    public required  string LastName { get; set; }
    public required  string Email { get; set; } 
    public UserRole Role { get; set; }
    public required string Password { get; set; }
}