using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class FloorSeedData
{
    public static readonly Floor[] Items =
    {
        new()
        {
            Id = Guid.Parse("f2000000-0000-0000-0000-000000000001"), Title = "1 этаж",
            MapURL = "https://storage.yandexcloud.net/youngcon/FirstFloor.png"
        },
        new()
        {
            Id = Guid.Parse("f2000000-0000-0000-0000-000000000002"), Title = "2 этаж",
            MapURL = "https://storage.yandexcloud.net/youngcon/SecondFloor.png"
        },
    };
}