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
            Icon = "https://disk.yandex.ru/i/iKkOIrUSoGj94g",
            Color = "#2563EB",
            CoordX = 0.66,
            CoordY = 0.48
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000002"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Зал воркшопов",
            Description = "Практические сессии и разборы",
            Icon = "https://disk.yandex.ru/i/dpqf86-EPl3LZQ",
            Color = "#7C3AED",
            CoordX = 0.22,
            CoordY = 0.11
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000003"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Карьерная зона",
            Description = "Консультации и карьерные треки",
            Icon = "https://disk.yandex.ru/i/Brxe_BOEQLs4Uw",
            Color = "#059669",
            CoordX = 0.25,
            CoordY = 0.36
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000004"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Лаборатория ИИ",
            Description = "Демо и стенды по ML",
            Icon = "https://disk.yandex.ru/i/Brxe_BOEQLs4Uw",
            Color = "#DC2626",
            CoordX = 0.52,
            CoordY = 0.08
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000005"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Мобильная точка",
            Description = "iOS и Android практики",
            Icon = "https://disk.yandex.ru/i/wJm1eOGLzPXgKA",
            Color = "#EA580C",
            CoordX = 0.78,
            CoordY = 0.11
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000006"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Бэкенд-комната",
            Description = "Серверные технологии и архитектура",
            Icon = "https://disk.yandex.ru/i/Mq_B4ltBwXqERA",
            Color = "#0F766E",
            CoordX = 0.18,
            CoordY = 0.82
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000007"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Дизайн-уголок",
            Description = "UX, интерфейсы и прототипы",
            Icon = "https://disk.yandex.ru/i/NoBvNU5C1kyYHA",
            Color = "#BE185D",
            CoordX = 0.72,
            CoordY = 0.82
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000008"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Хаб безопасности",
            Description = "Безопасная разработка и лучшие практики",
            Icon = "https://disk.yandex.ru/i/SRL4it0fUb1Vyg",
            Color = "#334155",
            CoordX = 0.72,
            CoordY = 0.86
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000009"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"),
            Title = "Стартап-площадка",
            Description = "Питчи, гипотезы и рост",
            Icon = "https://disk.yandex.ru/i/vuHGvBAe5txuRAl",
            Color = "#4F46E5",
            CoordX = 0.75,
            CoordY = 0.44
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-00000000000a"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"),
            Title = "Комьюнити-зона",
            Description = "Нетворкинг и вопросы экспертам",
            Icon = "https://disk.yandex.ru/i/6MvK-ECffChbPg",
            Color = "#16A34A",
            CoordX = 0.18,
            CoordY = 0.23
        }
    };
}