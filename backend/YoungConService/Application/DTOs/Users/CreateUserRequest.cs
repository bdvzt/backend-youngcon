using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using YoungConService.Domain.Enums;

namespace YoungConService.DTOs.Users;

public class CreateUserRequest
{ 
    [Required(ErrorMessage = "Имя обязательно")]
    [MinLength(2, ErrorMessage = "Имя должно быть не менее 2 символов")]
    [MaxLength(100, ErrorMessage = "Имя не может быть длиннее 100 символов")]
    [DefaultValue("Иван")]
    public required string FirstName { get; set; }
    
    [Required(ErrorMessage = "Фамилия обязательна")]
    [MinLength(2, ErrorMessage = "Фамилия должна быть не менее 2 символов")]
    [MaxLength(100, ErrorMessage = "Фамилия не может быть длиннее 100 символов")]
    [DefaultValue("Иванов")]
    public required string LastName { get; set; }
    
    [Required(ErrorMessage = "Email обязателен")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Некорректный формат Email")]
    [MaxLength(255, ErrorMessage = "Email не может быть длиннее 255 символов")]
    [DefaultValue("user@example.com")]
    public required string Email { get; set; } 
    
    [Required(ErrorMessage = "QR код обязателен")]
    [MinLength(5, ErrorMessage = "QR код должен быть не менее 5 символов")]
    [MaxLength(255, ErrorMessage = "QR код не может быть длиннее 255 символов")]
    [DefaultValue("QR001")]
    public required string QrCode { get; set; }
    
    [DefaultValue(0)]
    public Major Major { get; set; }
    
    [DefaultValue(1)]
    public UserRole Role { get; set; }
    
    [Required(ErrorMessage = "Пароль обязателен")]
    [MinLength(6, ErrorMessage = "Пароль должен быть не менее 6 символов")]
    [MaxLength(100, ErrorMessage = "Пароль не может быть длиннее 100 символов")]
    [DefaultValue("password123")]
    public required string Password { get; set; }
}