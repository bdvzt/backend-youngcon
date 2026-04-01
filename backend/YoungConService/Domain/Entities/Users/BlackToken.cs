namespace YoungConService.Domain.Entities;

public class BlackToken
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Token { get; set; }
    public DateTime ExpiryDate { get; set; } = DateTime.UtcNow;
}