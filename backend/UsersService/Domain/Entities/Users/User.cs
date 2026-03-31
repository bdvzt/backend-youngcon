using UsersService.Domain.Enums;

namespace UsersService.Domain.Entities;

public class User
{
    public required Guid Id { get; set; }
    public required string FirstName { get; set; } 
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string HashPassword { get; set; }
    public UserRole Role { get; set; }
    public required DateTime Created { get; set; }
    
    public DateTime? Updated { get; set; }
}