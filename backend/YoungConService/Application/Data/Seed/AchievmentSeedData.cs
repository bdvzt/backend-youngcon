using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class AchievmentSeedData
{
    public static readonly Achievment[] Items =
    {
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000001"), Name = "Первый вход",
            Description = "Первый вход в приложение", Icon = "star.fill", Color = "#2563EB"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000002"), Name = "Исследователь",
            Description = "Просмотрено 5 событий", Icon = "safari.fill", Color = "#7C3AED"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000003"), Name = "Фестивальный фанат",
            Description = "Добавлен первый фестиваль в избранное", Icon = "heart.fill", Color = "#DC2626"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000004"), Name = "Нетворкер",
            Description = "Посещено 3 зоны общения", Icon = "person.3.fill", Color = "#16A34A"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000005"), Name = "Внимательный слушатель",
            Description = "Прослушано 3 доклада", Icon = "mic.fill", Color = "#EA580C"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000006"), Name = "Герой воркшопов",
            Description = "Участие в 2 воркшопах", Icon = "wrench.and.screwdriver.fill", Color = "#0F766E"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000007"), Name = "Безопасный подход",
            Description = "Пройден трек по безопасности", Icon = "lock.shield.fill", Color = "#334155"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000008"), Name = "Продуктовое мышление",
            Description = "Посещение продуктовой сессии", Icon = "lightbulb.fill", Color = "#BE185D"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000009"), Name = "Чувство дизайна",
            Description = "Посещение дизайн-зоны", Icon = "paintpalette.fill", Color = "#4F46E5"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-00000000000a"), Name = "Целый день",
            Description = "Полный день на фестивале", Icon = "calendar.badge.clock", Color = "#059669"
        }
    };
}