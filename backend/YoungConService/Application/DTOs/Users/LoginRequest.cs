using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Users;

public class LoginRequest
{
    [Required(ErrorMessage = "Email обязателен")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Некорректный формат Email")]
    [MaxLength(255, ErrorMessage = "Email не может быть длиннее 255 символов")]
    [DefaultValue("user@example.com")]
    public required string Email { get; set; } 
    
    [Required(ErrorMessage = "Пароль обязателен")]
    [MinLength(6, ErrorMessage = "Пароль должен быть не менее 6 символов")]
    [MaxLength(100, ErrorMessage = "Пароль не может быть длиннее 100 символов")]
    [DefaultValue("password123")]
    public required string Password { get; set; }
}