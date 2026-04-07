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
            Bio = "Руководит мобильной разработкой, выстраивает архитектуру iOS-приложений и процессы команды.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.31.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000002"),
            FullName = "Андрей Сикерин",
            Job = "iOS-разработчик в Yandex Browser",
            Bio = "Разрабатывает и оптимизирует iOS-фичи браузера, улучшает производительность и пользовательский опыт.",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000003"),
            FullName = "Мария Журавлева",
            Job = "HR manager",
            Bio = "Отвечает за найм и развитие инженерных команд, сопровождает карьерные треки специалистов.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.25.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000004"),
            FullName = "Илья Соловьев",
            Job = "iOS-разработчик в Yandex Browser",
            Bio = "Занимается клиентской разработкой iOS-приложения и внедряет новые продуктовые сценарии.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.08.30.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000005"),
            FullName = "Тимур Долозаткин",
            Job = "iOS инженер Yandex Go",
            Bio = "Разрабатывает ключевые iOS-компоненты Yandex Go и поддерживает стабильность релизов.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.12.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000006"),
            FullName = "Дима Деларю",
            Job = "iOS-разработчик Yandex Go",
            Bio = "Фокусируется на продуктовых iOS-фичах, улучшает качество кода и пользовательский опыт.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.38.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000007"),
            FullName = "Антон Таранов",
            Job = "iOS-разработчик SuperApp",
            Bio = "Разрабатывает iOS-модули SuperApp и интеграции между сервисами.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.44.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000008"),
            FullName = "Никикта Леванов",
            Job = "iOS-разработчик Yandex Go",
            Bio = "Работает над iOS-архитектурой и инфраструктурой приложения, повышает надежность клиентской части.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.08.55.jpeg"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000009"),
            FullName = "Анастасия Талмазан",
            Job = "iOS-разработчик SuperApp",
            Bio = "Отвечает за развитие iOS-функциональности SuperApp и быстрый запуск новых сценариев.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%C2%A0%E2%80%94%202026-04-07%20%D0%B2%C2%A017.10.48.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-00000000000a"),
            FullName = "Степан Потапов",
            Job = "iOS-разработчик Yandex Plus",
            Bio = "Развивает iOS-приложение Yandex Plus, работает над подписочными и медиасценариями.",
            AvatarURL = "https://storage.yandexcloud.net/youngcon/stepan.png"
        }
    };
}