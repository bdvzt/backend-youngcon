using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Events;

public class CreateEventRequest
{
    [Required(ErrorMessage = "Название события обязательно")]
    [MinLength(3, ErrorMessage = "Название должно быть не менее 3 символов")]
    [MaxLength(255, ErrorMessage = "Название не может быть длиннее 255 символов")]
    public required string Title { get; set; }
    
    [Required(ErrorMessage = "Описание обязательно")]
    [MinLength(10, ErrorMessage = "Описание должно быть не менее 10 символов")]
    [MaxLength(2000, ErrorMessage = "Описание не может быть длиннее 2000 символов")]
    public required string Description { get; set; }
    
    [Required(ErrorMessage = "Дата начала обязательна")]
    public required DateTime StartDateTime { get; set; }
    
    [Required(ErrorMessage = "Дата окончания обязательна")]
    public required DateTime EndDateTime { get; set; }
    
    [Required(ErrorMessage = "Категория обязательна")]
    [MinLength(3, ErrorMessage = "Категория должна быть не менее 3 символов")]
    [MaxLength(100, ErrorMessage = "Категория не может быть длиннее 100 символов")]
    public required string Category { get; set; }
    
    [Required(ErrorMessage = "ZoneId обязателен")]
    public required Guid ZoneId { get; set; }
    
    [Required(ErrorMessage = "FestivalId обязателен")]
    public required Guid FestivalId { get; set; }
    
    public Guid? SpeakerId { get; set; }
}
