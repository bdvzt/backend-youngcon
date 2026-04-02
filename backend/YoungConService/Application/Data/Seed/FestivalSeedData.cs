using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class FestivalSeedData
{
    public static readonly Festival[] Items =
    {
        new()
        {
            Id = Guid.Parse("f1000000-0000-0000-0000-000000000001"), Title = "YoungCon 2026",
            Description = "Главный фестиваль про технологии, карьеру и сообщества",
            StartDateTime = new DateTime(2026, 6, 25, 8, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 20, 0, 0, DateTimeKind.Utc)
        }
    };
}