using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class SpeakerSeedData
{
    public static readonly Speaker[] Items =
    {
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000001"),
            FullName = "Алексей Агеев",
            Job = "Техлид команды мобильной разработки в Межгороде",
            Bio = "15 лет развивает веб-платформы и клиентские архитектуры",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.31.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000002"),
            FullName = "Андрей Сикерин",
            Job = "Техлид мобильной разработки",
            Bio = "Создает мобильные приложения для миллионов пользователей",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000003"),
            FullName = "Мария Журавлева",
            Job = "HR manager",
            Bio = "Проектирует рекомендательные и поисковые модели",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.25.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000004"),
            FullName = "Илья Соловьев",
            Job = "DevOps-архитектор",
            Bio = "Автоматизирует облачную инфраструктуру и релизы",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.08.30.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000005"),
            FullName = "Тимур Долозаткин",
            Job = "iOS инженер Yandex Go",
            Bio = "Специализируется на распределенных сервисах",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.12.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000006"),
            FullName = "Дима Деларю",
            Job = "iOS-разработчик Yandex Go",
            Bio = "Ведет кросс-функциональные продуктовые команды",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.38.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000007"),
            FullName = "Антон Таранов",
            Job = "UX-дизайнер",
            Bio = "Проектирует интерфейсы на основе пользовательских данных",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.44.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000008"),
            FullName = "Никикта Леванов",
            Job = "iOS-разработчик Yandex Go",
            Bio = "Занимается безопасностью приложений и API",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.08.55.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000009"),
            FullName = "Анастасия Талмазан",
            Job = "Yandex Go SuperApp",
            Bio = "Помогает командам на ранней стадии роста",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%C2%A0%E2%80%94%202026-04-07%20%D0%B2%C2%A017.10.48.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-00000000000a"),
            FullName = "Ольга Андреева",
            Job = "Лид комьюнити",
            Bio = "Развивает инженерные и продуктовые сообщества",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        }
    };
}