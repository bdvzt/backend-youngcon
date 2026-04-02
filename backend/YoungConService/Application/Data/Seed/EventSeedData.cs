using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class EventSeedData
{
    public static readonly Event[] Items =
    {
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000001"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000001"),
            Title = "Открывающий доклад",
            Description = "Торжественное открытие фестиваля",
            StartDateTime = new DateTime(2026, 6, 25, 8, 30, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 9, 30, 0, DateTimeKind.Utc), Category = "Пленарный доклад"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000002"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000002"),
            Title = "Состояние мобильной разработки",
            Description = "Тренды и инструменты мобильной экосистемы",
            StartDateTime = new DateTime(2026, 7, 2, 10, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 7, 2, 11, 0, 0, DateTimeKind.Utc), Category = "Доклад"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000003"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000003"),
            Title = "ML в продакшене",
            Description = "Практика внедрения моделей в продукты",
            StartDateTime = new DateTime(2026, 7, 9, 11, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 7, 9, 12, 0, 0, DateTimeKind.Utc), Category = "Кейс"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000004"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000004"),
            Title = "Шаблоны CI/CD",
            Description = "Подходы к стабильным релизам",
            StartDateTime = new DateTime(2026, 7, 16, 12, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 7, 16, 13, 0, 0, DateTimeKind.Utc), Category = "Воркшоп"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000005"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000005"),
            Title = "Надежные API",
            Description = "Проектирование отказоустойчивых интерфейсов",
            StartDateTime = new DateTime(2026, 7, 23, 13, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 7, 23, 14, 0, 0, DateTimeKind.Utc), Category = "Доклад"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000006"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000006"),
            Title = "Поиск продуктовой ценности",
            Description = "Как находить и проверять гипотезы",
            StartDateTime = new DateTime(2026, 7, 30, 14, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 7, 30, 15, 0, 0, DateTimeKind.Utc), Category = "Кейс"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000007"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000007"),
            Title = "Дизайн-системы",
            Description = "Системный подход к интерфейсам",
            StartDateTime = new DateTime(2026, 8, 6, 11, 30, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 8, 6, 12, 30, 0, DateTimeKind.Utc), Category = "Доклад"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000008"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000008"),
            Title = "Безопасность по умолчанию",
            Description = "Безопасная разработка на каждом этапе",
            StartDateTime = new DateTime(2026, 8, 13, 12, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 8, 13, 13, 0, 0, DateTimeKind.Utc), Category = "Воркшоп"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000009"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000009"),
            Title = "Ошибки стартапов",
            Description = "Типичные ошибки ранних стадий",
            StartDateTime = new DateTime(2026, 8, 20, 13, 30, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 8, 20, 14, 30, 0, DateTimeKind.Utc), Category = "Панель"
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-00000000000a"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-00000000000a"),
            Title = "Открытый микрофон",
            Description = "Вопросы и ответы с экспертами",
            StartDateTime = new DateTime(2026, 8, 27, 16, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 8, 27, 17, 0, 0, DateTimeKind.Utc), Category = "Вопросы и ответы"
        }
    };
}