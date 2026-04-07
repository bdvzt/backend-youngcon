using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class ZoneSeedData
{
    public static readonly Zone[] Items =
    {
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000001"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Главная сцена",
            Description = "Ключевые доклады и открытие",
            Icon = "https://storage.yandexcloud.net/youngcon/scene.png",
            Color = "#FF87BB",
            CoordX = 0.66,
            CoordY = 0.48
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000002"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Зал воркшопов",
            Description = "Практические сессии и разборы",
            Icon = "https://storage.yandexcloud.net/youngcon/work.png",
            Color = "#FCFF72",
            CoordX = 0.22,
            CoordY = 0.11
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000003"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Карьерная зона",
            Description = "Консультации и карьерные треки",
            Icon = "https://storage.yandexcloud.net/youngcon/career.png",
            Color = "#FCFF72",
            CoordX = 0.25,
            CoordY = 0.36
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000004"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Лаборатория ИИ",
            Description = "Демо и стенды по ML",
            Icon = "https://storage.yandexcloud.net/youngcon/ai.png",
            Color = "#C59EFF",
            CoordX = 0.52,
            CoordY = 0.08
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000005"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Мобильная точка",
            Description = "iOS и Android практики",
            Icon = "https://storage.yandexcloud.net/youngcon/phome.png",
            Color = "#C59EFF",
            CoordX = 0.78,
            CoordY = 0.11
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000006"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Бэкенд-комната",
            Description = "Серверные технологии и архитектура",
            Icon = "https://storage.yandexcloud.net/youngcon/server.png",
            Color = "#C59EFF",
            CoordX = 0.18,
            CoordY = 0.82
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000007"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Дизайн-уголок",
            Description = "UX, интерфейсы и прототипы",
            Icon = "https://storage.yandexcloud.net/youngcon/design.png",
            Color = "#FCFF72",
            CoordX = 0.72,
            CoordY = 0.82
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000008"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Хаб безопасности",
            Description = "Безопасная разработка и лучшие практики",
            Icon = "https://storage.yandexcloud.net/youngcon/shield.png",
            Color = "#C59EFF",
            CoordX = 0.72,
            CoordY = 0.86
        },
        new()
       {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000009"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Стартап-площадка",
            Description = "Питчи, гипотезы и рост",
            Icon = "https://storage.yandexcloud.net/youngcon/rocket.png",
            Color = "#FF87BB",
            CoordX = 0.75,
            CoordY = 0.44
        },
       new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-00000000000a"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Комьюнити-зона",
            Description = "Нетворкинг и вопросы экспертам",
            Icon = "https://storage.yandexcloud.net/youngcon/networking.png",
            Color = "#FF87BB",
            CoordX = 0.18,
            CoordY = 0.23
        }
    };
}