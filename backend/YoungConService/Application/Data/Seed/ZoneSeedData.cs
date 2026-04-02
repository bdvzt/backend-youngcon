using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class ZoneSeedData
{
    public static readonly Zone[] Items =
    {
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000001"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"), Title = "Главная сцена",
            Description = "Ключевые доклады и открытие", Icon = "sparkles.rectangle.stack.fill", Color = "#2563EB"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000002"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"), Title = "Зал воркшопов",
            Description = "Практические сессии и разборы", Icon = "hammer.fill", Color = "#7C3AED"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000003"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"), Title = "Карьерная зона",
            Description = "Консультации и карьерные треки", Icon = "briefcase.fill", Color = "#059669"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000004"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"), Title = "Лаборатория ИИ",
            Description = "Демо и стенды по ML", Icon = "brain.head.profile", Color = "#DC2626"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000005"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"), Title = "Мобильная точка",
            Description = "iOS и Android практики", Icon = "iphone.gen3", Color = "#EA580C"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000006"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"), Title = "Бэкенд-комната",
            Description = "Серверные технологии и архитектура", Icon = "server.rack", Color = "#0F766E"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000007"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"), Title = "Дизайн-уголок",
            Description = "UX, интерфейсы и прототипы", Icon = "paintpalette.fill", Color = "#BE185D"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000008"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"), Title = "Хаб безопасности",
            Description = "Безопасная разработка и лучшие практики", Icon = "shield.lefthalf.filled", Color = "#334155"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-000000000009"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000002"), Title = "Стартап-площадка",
            Description = "Питчи, гипотезы и рост", Icon = "paperplane.fill", Color = "#4F46E5"
        },
        new()
        {
            Id = Guid.Parse("f3000000-0000-0000-0000-00000000000a"),
            FloorId = Guid.Parse("f2000000-0000-0000-0000-000000000001"), Title = "Комьюнити-зона",
            Description = "Нетворкинг и вопросы экспертам", Icon = "person.3.fill", Color = "#16A34A"
        }
    };
}