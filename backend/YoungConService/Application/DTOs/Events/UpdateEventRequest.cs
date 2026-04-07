using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Events;

public class UpdateEventRequest
{
    [MinLength(3, ErrorMessage = "Название должно быть не менее 3 символов")]
    [MaxLength(255, ErrorMessage = "Название не может быть длиннее 255 символов")]
    public string? Title { get; set; }
    
    [MinLength(10, ErrorMessage = "Описание должно быть не менее 10 символов")]
    [MaxLength(2000, ErrorMessage = "Описание не может быть длиннее 2000 символов")]
    public string? Description { get; set; }
    
    public DateTime? StartDateTime { get; set; }
    public DateTime? EndDateTime { get; set; }
    
    [MinLength(3, ErrorMessage = "Категория должна быть не менее 3 символов")]
    [MaxLength(100, ErrorMessage = "Категория не может быть длиннее 100 символов")]
    public string? Category { get; set; }
    
    public Guid? ZoneId { get; set; }
    public Guid? FestivalId { get; set; }
    
    [Url(ErrorMessage = "StreamURL должен быть корректным URL")]
    public string? StreamURL { get; set; }
    
    public Guid[]? SpeakerIds { get; set; }
}
