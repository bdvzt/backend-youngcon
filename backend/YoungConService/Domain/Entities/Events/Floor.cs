namespace YoungConService.Domain.Entities;

public class Floor
{
    public required Guid Id { get; set; }
    public required string Title { get; set; } 
    public required string MapURL { get; set; }
    public ICollection<Zone> Zones { get; set; } = [];
}