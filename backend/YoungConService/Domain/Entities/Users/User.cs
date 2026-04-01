using YoungConService.Domain.Enums;

namespace YoungConService.Domain.Entities;

public class User
{
    public required Guid Id { get; set; }
    public required string FirstName { get; set; } 
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string QrCode { get; set; }
    public required Major Major { get; set; }
    public ICollection<Achievment> Achievments { get; set; } = [];
    public ICollection<Event> LikedEvents { get; set; } = [];
    public required string HashPassword { get; set; }
    public UserRole Role { get; set; }
    public required DateTime Created { get; set; }
    
    public DateTime? Updated { get; set; }
}