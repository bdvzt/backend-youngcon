using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Speakers;

public class CreateSpeakerRequest
{
    [Required(ErrorMessage = "Полное имя обязательно")]
    [MinLength(3, ErrorMessage = "Полное имя должно быть не менее 3 символов")]
    [MaxLength(255, ErrorMessage = "Полное имя не может быть длиннее 255 символов")]
    public required string FullName { get; set; }
    
    [Required(ErrorMessage = "Должность обязательна")]
    [MinLength(3, ErrorMessage = "Должность должна быть не менее 3 символов")]
    [MaxLength(100, ErrorMessage = "Должность не может быть длиннее 100 символов")]
    public required string Job { get; set; }
    
    [Required(ErrorMessage = "Биография обязательна")]
    [MinLength(10, ErrorMessage = "Биография должна быть не менее 10 символов")]
    [MaxLength(1000, ErrorMessage = "Биография не может быть длиннее 1000 символов")]
    public required string Bio { get; set; }
    
    [Required(ErrorMessage = "URL аватара обязателен")]
    [Url(ErrorMessage = "Некорректный формат URL")]
    public required string AvatarURL { get; set; }
}
