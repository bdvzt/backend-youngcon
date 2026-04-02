using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class SpeakerSeedData
{
    public static readonly Speaker[] Items =
    {
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000001"),
            FullName = "Алексей Смирнов",
            Job = "Старший фронтенд-инженер",
            Bio = "15 лет развивает веб-платформы и клиентские архитектуры",
            AvatarURL = "https://youngcon.local/avatars/speaker-1.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000002"),
            FullName = "Мария Петрова",
            Job = "Техлид мобильной разработки",
            Bio = "Создает мобильные приложения для миллионов пользователей",
            AvatarURL = "https://youngcon.local/avatars/speaker-2.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000003"),
            FullName = "Иван Волков",
            Job = "ML-инженер",
            Bio = "Проектирует рекомендательные и поисковые модели",
            AvatarURL = "https://youngcon.local/avatars/speaker-3.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000004"),
            FullName = "Елена Сокол",
            Job = "DevOps-архитектор",
            Bio = "Автоматизирует облачную инфраструктуру и релизы",
            AvatarURL = "https://youngcon.local/avatars/speaker-4.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000005"),
            FullName = "Никита Орлов",
            Job = "Бэкенд-инженер",
            Bio = "Специализируется на распределенных сервисах",
            AvatarURL = "https://youngcon.local/avatars/speaker-5.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000006"),
            FullName = "Анна Белова",
            Job = "Продакт-менеджер",
            Bio = "Ведет кросс-функциональные продуктовые команды",
            AvatarURL = "https://youngcon.local/avatars/speaker-6.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000007"),
            FullName = "Дмитрий Егоров",
            Job = "UX-дизайнер",
            Bio = "Проектирует интерфейсы на основе пользовательских данных",
            AvatarURL = "https://youngcon.local/avatars/speaker-7.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000008"),
            FullName = "София Медведева",
            Job = "Инженер по безопасности",
            Bio = "Занимается безопасностью приложений и API",
            AvatarURL = "https://youngcon.local/avatars/speaker-8.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-000000000009"),
            FullName = "Павел Зорин",
            Job = "Ментор стартапов",
            Bio = "Помогает командам на ранней стадии роста",
            AvatarURL = "https://youngcon.local/avatars/speaker-9.png"
        },
        new()
        {
            Id = Guid.Parse("f4000000-0000-0000-0000-00000000000a"),
            FullName = "Ольга Андреева",
            Job = "Лид комьюнити",
            Bio = "Развивает инженерные и продуктовые сообщества",
            AvatarURL = "https://youngcon.local/avatars/speaker-10.png"
        }
    };
}