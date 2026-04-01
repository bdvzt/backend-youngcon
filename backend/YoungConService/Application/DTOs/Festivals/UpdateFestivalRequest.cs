using System.ComponentModel.DataAnnotations;

namespace YoungConService.DTOs.Festivals;

public class UpdateFestivalRequest
{
    [MinLength(3, ErrorMessage = "Название должно быть не менее 3 символов")]
    [MaxLength(255, ErrorMessage = "Название не может быть длиннее 255 символов")]
    public string? Title { get; set; }
    
    [MinLength(10, ErrorMessage = "Описание должно быть не менее 10 символов")]
    [MaxLength(2000, ErrorMessage = "Описание не может быть длиннее 2000 символов")]
    public string? Description { get; set; }
    
    public DateTime? StartDateTime { get; set; }
    public DateTime? EndDateTime { get; set; }
}

