using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class AchievmentSeedData
{
    public static readonly Achievment[] Items =
    {
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000001"), Name = "Ранняя пташка",
            Description = "Отсканируй бейдж при входе и окажись среди первых 30 участников фестиваля.", Icon = "https://storage.yandexcloud.net/youngcon/first.png", Color = "#FF87BB"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000002"), Name = "Слушатель",
            Description = "Отсканируй бейдж на одной из лекций.", Icon = "https://storage.yandexcloud.net/youngcon/headphones.png", Color = "#C59EFF"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000003"), Name = "Кофеман",
            Description = "Отсканируй бейдж в кофе-поинте и получи фирменный напиток от партнёров.", Icon = "https://storage.yandexcloud.net/youngcon/coffee1.png", Color = "#FCFF72"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000004"), Name = "Нетворкер",
            Description = "Обменяйся контактами с 3 разными участниками и отсканируй бейдж в комьюнити-зоне.", Icon = "https://storage.yandexcloud.net/youngcon/network.png", Color = "#FF87BB"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000005"), Name = "Поехали",
            Description = "Побывайте на прямой трансляции с МКС.", Icon = "https://storage.yandexcloud.net/youngcon/mks.png", Color = "#C59EFF"
        },
        new()
        {
            Id = Guid.Parse("f6000000-0000-0000-0000-000000000006"), Name = "Оффер в кармане",
            Description = "Пройти Fast Track и получи приглашение на собеседование.", Icon = "https://storage.yandexcloud.net/youngcon/offer.png", Color = "#FCFF72"
        }
    };
}
