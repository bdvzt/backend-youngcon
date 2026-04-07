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
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
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
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000004"),
            FullName = "Илья Соловьев",
            Job = "DevOps-архитектор",
            Bio = "Автоматизирует облачную инфраструктуру и релизы",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000005"),
            FullName = "Тимур Долозаткин",
            Job = "iOS инженер Yandex Go",
            Bio = "Специализируется на распределенных сервисах",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000006"),
            FullName = "Дима Деларю",
            Job = "iOS-разработчик Yandex Go",
            Bio = "Ведет кросс-функциональные продуктовые команды",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000007"),
            FullName = "Антон Таранов",
            Job = "UX-дизайнер",
            Bio = "Проектирует интерфейсы на основе пользовательских данных",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000008"),
            FullName = "Никикта Леванов",
            Job = "iOS-разработчик Yandex Go",
            Bio = "Занимается безопасностью приложений и API",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000009"),
            FullName = "Анастасия Талмазан",
            Job = "Yandex Go SuperApp",
            Bio = "Помогает командам на ранней стадии роста",
            AvatarURL = "https://disk.yandex.ru/i/UQpqThhyd6LYiw"
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