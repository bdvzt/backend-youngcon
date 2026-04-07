using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoungConService.Migrations
{
    /// <inheritdoc />
    public partial class AddEventStreamUrlAndZoneCoords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-00000000000a"));

            migrationBuilder.AddColumn<double>(
                name: "CoordX",
                table: "Zones",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CoordY",
                table: "Zones",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "StreamURL",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000001"),
                columns: new[] { "Icon", "Name" },
                values: new object[] { "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "КВЕСТ ПРОЙДЕН" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000002"),
                columns: new[] { "Icon", "Name" },
                values: new object[] { "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "КОФЕМАН" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000003"),
                columns: new[] { "Icon", "Name" },
                values: new object[] { "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "НЕТВОРКЕР" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000004"),
                columns: new[] { "Description", "Icon", "Name" },
                values: new object[] { "Проведен весь день на фестивале (11:00–23:00)", "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "ЦЕЛЫЙ ДЕНЬ" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000005"),
                columns: new[] { "Icon", "Name" },
                values: new object[] { "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "ОФФЕР В КАРМАНЕ!" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000001"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Торжественное открытие конференции. Обзор платформы, основные возможности и план развития", new DateTime(2026, 6, 25, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 8, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=TdnLjukE6Ws&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=1", "Вводная по платформе" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000002"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Первая часть углубленного курса по Swift. Изучаем продвинутые концепции и лучшие практики программирования на Swift", new DateTime(2026, 6, 25, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 9, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=C2k_GzjdDQk&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=2", "Advanced Swift programming Part 1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000003"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Вторая часть углубленного курса по Swift. Продолжение изучения сложных паттернов и оптимизации кода", new DateTime(2026, 6, 25, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 10, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=XDZal1OUbrU&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=3", "Advanced Swift programming Part 2" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000004"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Введение в SwiftUI. Основы построения пользовательских интерфейсов с использованием декларативного подхода", new DateTime(2026, 6, 25, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 11, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=NZ46DBOaUzc&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=4", "Basic SwiftUI" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000005"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Продвинутые техники в SwiftUI. Работа со сложными состояниями, анимациями и оптимизацией производительности", new DateTime(2026, 6, 25, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 12, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=FPJNTfR6_J8&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=5", "Advanced SwiftUI" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000006"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Классический подход к разработке интерфейсов на iOS. Основные компоненты и практические примеры использования UIKit", new DateTime(2026, 6, 25, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 13, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=1PdibPZQu7w&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=6", "UIKit" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000007"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Паттерны архитектуры приложений iOS. MVVM, VIPER, Clean Architecture и их применение в реальных проектах", new DateTime(2026, 6, 25, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 14, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=qhG36NquE8M&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=7", "Архитектура" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000008"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Инструменты разработки для iOS. Xcode, системы управления зависимостями и оптимизация workflow разработчика", new DateTime(2026, 6, 25, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 15, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=kJtf5InGOME&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=8", "IDE, Toolchain, Cocoapods/SPM" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000009"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Основы многопоточности в Swift. Главная очередь, фоновые потоки и синхронизация данных", new DateTime(2026, 6, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 16, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=2sktj5cL4wg&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=9", "Basic Concurrency" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-00000000000a"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "StreamURL", "Title" },
                values: new object[] { "Продвинутые концепции многопоточности в Swift. Async/await, actors и обработка ошибок при асинхронной работе", new DateTime(2026, 6, 25, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 17, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=MKgtXIStCfk&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=10", "Advanced Concurrency" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000001"),
                columns: new[] { "AvatarURL", "FullName", "Job" },
                values: new object[] { "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Степан Потапов", "iOS-разработчик команды плюса" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000002"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000003"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000004"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000005"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000006"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000007"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000008"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000009"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-00000000000a"),
                column: "AvatarURL",
                value: "https://disk.yandex.ru/i/UQpqThhyd6LYiw");

            // Idempotent seed for existing databases: do not fail if rows already exist.
            migrationBuilder.Sql("""
                INSERT INTO "UserAchievments" ("AchievmentsId", "UserId")
                VALUES ('f6000000-0000-0000-0000-000000000001', '44444444-4444-4444-4444-444444444444')
                ON CONFLICT ("AchievmentsId", "UserId") DO NOTHING;

                INSERT INTO "UserAchievments" ("AchievmentsId", "UserId")
                VALUES ('f6000000-0000-0000-0000-000000000002', '44444444-4444-4444-4444-444444444444')
                ON CONFLICT ("AchievmentsId", "UserId") DO NOTHING;

                INSERT INTO "UserAchievments" ("AchievmentsId", "UserId")
                VALUES ('f6000000-0000-0000-0000-000000000003', '44444444-4444-4444-4444-444444444444')
                ON CONFLICT ("AchievmentsId", "UserId") DO NOTHING;
                """);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "Major",
                value: "IOS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "Major",
                value: "Backend");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "Major",
                value: "Flutter");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "Major",
                value: "ML");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "Major",
                value: "Android");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000001"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.10000000000000001, 0.20000000000000001, "https://disk.yandex.ru/i/iKkOIrUSoGj94g" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000002"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.29999999999999999, 0.14999999999999999, "https://disk.yandex.ru/i/dpqf86-EPl3LZQ" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000003"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.45000000000000001, 0.25, "https://disk.yandex.ru/i/Brxe_BOEQLs4Uw" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000004"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.20000000000000001, 0.34999999999999998, "https://disk.yandex.ru/i/Brxe_BOEQLs4Uw" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000005"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.5, 0.10000000000000001, "https://disk.yandex.ru/i/wJm1eOGLzPXgKA" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000006"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.14999999999999999, 0.5, "https://disk.yandex.ru/i/Mq_B4ltBwXqERA" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000007"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.40000000000000002, 0.40000000000000002, "https://disk.yandex.ru/i/NoBvNU5C1kyYHA" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000008"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.34999999999999998, 0.55000000000000004, "https://disk.yandex.ru/i/SRL4it0fUb1Vyg" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000009"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.55000000000000004, 0.29999999999999999, "https://disk.yandex.ru/i/vuHGvBAe5txuRAl" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-00000000000a"),
                columns: new[] { "CoordX", "CoordY", "Icon" },
                values: new object[] { 0.25, 0.45000000000000001, "https://disk.yandex.ru/i/6MvK-ECffChbPg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Skip delete for UserAchievments in Down because Up uses idempotent insert and
            // these rows may pre-exist before this migration.

            migrationBuilder.DropColumn(
                name: "CoordX",
                table: "Zones");

            migrationBuilder.DropColumn(
                name: "CoordY",
                table: "Zones");

            migrationBuilder.DropColumn(
                name: "StreamURL",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000001"),
                columns: new[] { "Icon", "Name" },
                values: new object[] { "star.fill", "Первый вход" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000002"),
                columns: new[] { "Icon", "Name" },
                values: new object[] { "safari.fill", "Исследователь" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000003"),
                columns: new[] { "Icon", "Name" },
                values: new object[] { "heart.fill", "Фестивальный фанат" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000004"),
                columns: new[] { "Description", "Icon", "Name" },
                values: new object[] { "Посещено 3 зоны общения", "person.3.fill", "Нетворкер" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000005"),
                columns: new[] { "Icon", "Name" },
                values: new object[] { "mic.fill", "Внимательный слушатель" });

            migrationBuilder.InsertData(
                table: "Achievments",
                columns: new[] { "Id", "Color", "Description", "Icon", "Name" },
                values: new object[,]
                {
                    { new Guid("f6000000-0000-0000-0000-000000000006"), "#0F766E", "Участие в 2 воркшопах", "wrench.and.screwdriver.fill", "Герой воркшопов" },
                    { new Guid("f6000000-0000-0000-0000-000000000007"), "#334155", "Пройден трек по безопасности", "lock.shield.fill", "Безопасный подход" },
                    { new Guid("f6000000-0000-0000-0000-000000000008"), "#BE185D", "Посещение продуктовой сессии", "lightbulb.fill", "Продуктовое мышление" },
                    { new Guid("f6000000-0000-0000-0000-000000000009"), "#4F46E5", "Посещение дизайн-зоны", "paintpalette.fill", "Чувство дизайна" },
                    { new Guid("f6000000-0000-0000-0000-00000000000a"), "#059669", "Полный день на фестивале", "calendar.badge.clock", "Целый день" }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000001"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Торжественное открытие фестиваля", new DateTime(2026, 6, 25, 9, 30, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 8, 30, 0, 0, DateTimeKind.Utc), "Открывающий доклад" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000002"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Тренды и инструменты мобильной экосистемы", new DateTime(2026, 7, 2, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 7, 2, 10, 0, 0, 0, DateTimeKind.Utc), "Состояние мобильной разработки" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000003"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Практика внедрения моделей в продукты", new DateTime(2026, 7, 9, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 7, 9, 11, 0, 0, 0, DateTimeKind.Utc), "ML в продакшене" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000004"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Подходы к стабильным релизам", new DateTime(2026, 7, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 7, 16, 12, 0, 0, 0, DateTimeKind.Utc), "Шаблоны CI/CD" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000005"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Проектирование отказоустойчивых интерфейсов", new DateTime(2026, 7, 23, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 7, 23, 13, 0, 0, 0, DateTimeKind.Utc), "Надежные API" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000006"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Как находить и проверять гипотезы", new DateTime(2026, 7, 30, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 7, 30, 14, 0, 0, 0, DateTimeKind.Utc), "Поиск продуктовой ценности" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000007"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Системный подход к интерфейсам", new DateTime(2026, 8, 6, 12, 30, 0, 0, DateTimeKind.Utc), new DateTime(2026, 8, 6, 11, 30, 0, 0, DateTimeKind.Utc), "Дизайн-системы" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000008"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Безопасная разработка на каждом этапе", new DateTime(2026, 8, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 8, 13, 12, 0, 0, 0, DateTimeKind.Utc), "Безопасность по умолчанию" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000009"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Типичные ошибки ранних стадий", new DateTime(2026, 8, 20, 14, 30, 0, 0, DateTimeKind.Utc), new DateTime(2026, 8, 20, 13, 30, 0, 0, DateTimeKind.Utc), "Ошибки стартапов" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-00000000000a"),
                columns: new[] { "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { "Вопросы и ответы с экспертами", new DateTime(2026, 8, 27, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 8, 27, 16, 0, 0, 0, DateTimeKind.Utc), "Открытый микрофон" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000001"),
                columns: new[] { "AvatarURL", "FullName", "Job" },
                values: new object[] { "https://youngcon.local/avatars/speaker-1.png", "Алексей Смирнов", "Старший фронтенд-инженер" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000002"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-2.png");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000003"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-3.png");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000004"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-4.png");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000005"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-5.png");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000006"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-6.png");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000007"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-7.png");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000008"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-8.png");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000009"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-9.png");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-00000000000a"),
                column: "AvatarURL",
                value: "https://youngcon.local/avatars/speaker-10.png");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "Major",
                value: "Mobile");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "Major",
                value: "ML");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "Major",
                value: "Frontend");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "Major",
                value: "Frontend");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "Major",
                value: "Mobile");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000001"),
                column: "Icon",
                value: "sparkles.rectangle.stack.fill");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000002"),
                column: "Icon",
                value: "hammer.fill");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000003"),
                column: "Icon",
                value: "briefcase.fill");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000004"),
                column: "Icon",
                value: "brain.head.profile");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000005"),
                column: "Icon",
                value: "iphone.gen3");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000006"),
                column: "Icon",
                value: "server.rack");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000007"),
                column: "Icon",
                value: "paintpalette.fill");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000008"),
                column: "Icon",
                value: "shield.lefthalf.filled");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000009"),
                column: "Icon",
                value: "paperplane.fill");

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-00000000000a"),
                column: "Icon",
                value: "person.3.fill");
        }
    }
}
