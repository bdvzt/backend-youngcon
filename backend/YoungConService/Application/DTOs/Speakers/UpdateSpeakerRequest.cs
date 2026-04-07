using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Speakers;

public class UpdateSpeakerRequest
{
    [MinLength(3, ErrorMessage = "Полное имя должно быть не менее 3 символов")]
    [MaxLength(255, ErrorMessage = "Полное имя не может быть длиннее 255 символов")]
    public string? FullName { get; set; }
    
    [MinLength(3, ErrorMessage = "Должность должна быть не менее 3 символов")]
    [MaxLength(100, ErrorMessage = "Должность не может быть длиннее 100 символов")]
    public string? Job { get; set; }
    
    [MinLength(10, ErrorMessage = "Биография должна быть не менее 10 символов")]
    [MaxLength(1000, ErrorMessage = "Биография не может быть длиннее 1000 символов")]
    public string? Bio { get; set; }
    
    [Url(ErrorMessage = "Некорректный формат URL")]
    public string? AvatarURL { get; set; }
}
