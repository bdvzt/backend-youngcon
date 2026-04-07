using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class AchievmentSeedData
{
    public static readonly Achievment[] Items =
    {
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000001"), Name = "КВЕСТ ПРОЙДЕН",
            Description = "Первый вход в приложение", Icon = "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", Color = "#2563EB"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000002"), Name = "КОФЕМАН",
            Description = "Просмотрено 5 событий", Icon = "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", Color = "#7C3AED"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000003"), Name = "НЕТВОРКЕР",
            Description = "Добавлен первый фестиваль в избранное", Icon = "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", Color = "#DC2626"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000004"), Name = "ЦЕЛЫЙ ДЕНЬ",
            Description = "Проведен весь день на фестивале (11:00–23:00)", Icon = "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", Color = "#16A34A"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000005"), Name = "ОФФЕР В КАРМАНЕ!",
            Description = "Прослушано 3 доклада", Icon = "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", Color = "#EA580C"
        }
    };
}