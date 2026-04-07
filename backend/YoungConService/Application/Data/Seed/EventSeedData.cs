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
            Title = "Вводная по платформе",
            Description = "Торжественное открытие конференции. Обзор платформы, основные возможности и план развития",
            StartDateTime = new DateTime(2026, 6, 25, 8, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 9, 0, 0, DateTimeKind.Utc), 
            Category = "Пленарный доклад",
            StreamURL = "https://www.youtube.com/watch?v=TdnLjukE6Ws&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=1",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000002"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000002"),
            Title = "Advanced Swift programming Part 1",
            Description = "Первая часть углубленного курса по Swift. Изучаем продвинутые концепции и лучшие практики программирования на Swift",
            StartDateTime = new DateTime(2026, 6, 25, 9, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 10, 0, 0, DateTimeKind.Utc), 
            Category = "Доклад",
            StreamURL = "https://www.youtube.com/watch?v=C2k_GzjdDQk&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=2",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000003"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000003"),
            Title = "Advanced Swift programming Part 2",
            Description = "Вторая часть углубленного курса по Swift. Продолжение изучения сложных паттернов и оптимизации кода",
            StartDateTime = new DateTime(2026, 6, 25, 10, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 11, 0, 0, DateTimeKind.Utc), 
            Category = "Кейс",
            StreamURL = "https://www.youtube.com/watch?v=XDZal1OUbrU&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=3",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000004"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000004"),
            Title = "Basic SwiftUI",
            Description = "Введение в SwiftUI. Основы построения пользовательских интерфейсов с использованием декларативного подхода",
            StartDateTime = new DateTime(2026, 6, 25, 11, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 12, 0, 0, DateTimeKind.Utc), 
            Category = "Воркшоп",
            StreamURL = "https://www.youtube.com/watch?v=NZ46DBOaUzc&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=4",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000005"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000005"),
            Title = "Advanced SwiftUI",
            Description = "Продвинутые техники в SwiftUI. Работа со сложными состояниями, анимациями и оптимизацией производительности",
            StartDateTime = new DateTime(2026, 6, 25, 12, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 13, 0, 0, DateTimeKind.Utc), 
            Category = "Доклад",
            StreamURL = "https://www.youtube.com/watch?v=FPJNTfR6_J8&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=5",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000006"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000006"),
            Title = "UIKit",
            Description = "Классический подход к разработке интерфейсов на iOS. Основные компоненты и практические примеры использования UIKit",
            StartDateTime = new DateTime(2026, 6, 25, 13, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 14, 0, 0, DateTimeKind.Utc), 
            Category = "Кейс",
            StreamURL = "https://www.youtube.com/watch?v=1PdibPZQu7w&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=6",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000007"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000007"),
            Title = "Архитектура",
            Description = "Паттерны архитектуры приложений iOS. MVVM, VIPER, Clean Architecture и их применение в реальных проектах",
            StartDateTime = new DateTime(2026, 6, 25, 14, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 15, 0, 0, DateTimeKind.Utc), 
            Category = "Доклад",
            StreamURL = "https://www.youtube.com/watch?v=qhG36NquE8M&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=7",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000008"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000008"),
            Title = "IDE, Toolchain, Cocoapods/SPM",
            Description = "Инструменты разработки для iOS. Xcode, системы управления зависимостями и оптимизация workflow разработчика",
            StartDateTime = new DateTime(2026, 6, 25, 15, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 16, 0, 0, DateTimeKind.Utc), 
            Category = "Воркшоп",
            StreamURL = "https://www.youtube.com/watch?v=kJtf5InGOME&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=8",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-000000000009"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-000000000009"),
            Title = "Basic Concurrency",
            Description = "Основы многопоточности в Swift. Главная очередь, фоновые потоки и синхронизация данных",
            StartDateTime = new DateTime(2026, 6, 25, 16, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 17, 0, 0, DateTimeKind.Utc), 
            Category = "Панель",
            StreamURL = "https://www.youtube.com/watch?v=2sktj5cL4wg&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=9",
            Speakers = []
        },
        new()
        {
            Id = Guid.Parse("f5000000-0000-0000-0000-00000000000a"),
            FestivalId = Guid.Parse("f1000000-0000-0000-0000-000000000001"),
            ZoneId = Guid.Parse("f3000000-0000-0000-0000-00000000000a"),
            Title = "Advanced Concurrency",
            Description = "Продвинутые концепции многопоточности в Swift. Async/await, actors и обработка ошибок при асинхронной работе",
            StartDateTime = new DateTime(2026, 6, 25, 17, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 6, 25, 20, 0, 0, DateTimeKind.Utc), 
            Category = "Вопросы и ответы",
            StreamURL = "https://www.youtube.com/watch?v=MKgtXIStCfk&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=10",
            Speakers = []
        }
    };
}