using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoungConService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlackTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Festivals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    MapURL = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Job = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    AvatarURL = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    QrCode = table.Column<string>(type: "text", nullable: false),
                    Major = table.Column<string>(type: "text", nullable: false),
                    HashPassword = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FloorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CoordX = table.Column<double>(type: "double precision", nullable: false),
                    CoordY = table.Column<double>(type: "double precision", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zones_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievments",
                columns: table => new
                {
                    AchievmentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievments", x => new { x.AchievmentsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserAchievments_Achievments_AchievmentsId",
                        column: x => x.AchievmentsId,
                        principalTable: "Achievments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZoneId = table.Column<Guid>(type: "uuid", nullable: false),
                    FestivalId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    StreamURL = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Festivals_FestivalId",
                        column: x => x.FestivalId,
                        principalTable: "Festivals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventSpeakers",
                columns: table => new
                {
                    EventsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeakersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSpeakers", x => new { x.EventsId, x.SpeakersId });
                    table.ForeignKey(
                        name: "FK_EventSpeakers_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventSpeakers_Speakers_SpeakersId",
                        column: x => x.SpeakersId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLikedEvents",
                columns: table => new
                {
                    LikedEventsId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLikedEvents", x => new { x.LikedEventsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserLikedEvents_Events_LikedEventsId",
                        column: x => x.LikedEventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLikedEvents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievments",
                columns: new[] { "Id", "Color", "Description", "Icon", "Name" },
                values: new object[,]
                {
                    { new Guid("f6000000-0000-0000-0000-000000000001"), "#2563EB", "Первый вход в приложение", "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "КВЕСТ ПРОЙДЕН" },
                    { new Guid("f6000000-0000-0000-0000-000000000002"), "#7C3AED", "Просмотрено 5 событий", "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "КОФЕМАН" },
                    { new Guid("f6000000-0000-0000-0000-000000000003"), "#DC2626", "Добавлен первый фестиваль в избранное", "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "НЕТВОРКЕР" },
                    { new Guid("f6000000-0000-0000-0000-000000000004"), "#16A34A", "Проведен весь день на фестивале (11:00–23:00)", "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "ЦЕЛЫЙ ДЕНЬ" },
                    { new Guid("f6000000-0000-0000-0000-000000000005"), "#EA580C", "Прослушано 3 доклада", "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g", "ОФФЕР В КАРМАНЕ!" }
                });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[] { new Guid("f1000000-0000-0000-0000-000000000001"), "Главный фестиваль про технологии, карьеру и сообщества", new DateTime(2026, 6, 25, 20, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 25, 8, 0, 0, 0, DateTimeKind.Utc), "YoungCon 2026" });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "MapURL", "Title" },
                values: new object[,]
                {
                    { new Guid("f2000000-0000-0000-0000-000000000001"), "https://youngcon.local/maps/floor-1", "1 этаж" },
                    { new Guid("f2000000-0000-0000-0000-000000000002"), "https://youngcon.local/maps/floor-2", "2 этаж" }
                });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "Id", "AvatarURL", "Bio", "FullName", "Job" },
                values: new object[,]
                {
                    { new Guid("f4000000-0000-0000-0000-000000000001"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "15 лет развивает веб-платформы и клиентские архитектуры", "Степан Потапов", "iOS-разработчик команды плюса" },
                    { new Guid("f4000000-0000-0000-0000-000000000002"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Создает мобильные приложения для миллионов пользователей", "Мария Петрова", "Техлид мобильной разработки" },
                    { new Guid("f4000000-0000-0000-0000-000000000003"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Проектирует рекомендательные и поисковые модели", "Иван Волков", "ML-инженер" },
                    { new Guid("f4000000-0000-0000-0000-000000000004"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Автоматизирует облачную инфраструктуру и релизы", "Елена Сокол", "DevOps-архитектор" },
                    { new Guid("f4000000-0000-0000-0000-000000000005"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Специализируется на распределенных сервисах", "Никита Орлов", "Бэкенд-инженер" },
                    { new Guid("f4000000-0000-0000-0000-000000000006"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Ведет кросс-функциональные продуктовые команды", "Анна Белова", "Продакт-менеджер" },
                    { new Guid("f4000000-0000-0000-0000-000000000007"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Проектирует интерфейсы на основе пользовательских данных", "Дмитрий Егоров", "UX-дизайнер" },
                    { new Guid("f4000000-0000-0000-0000-000000000008"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Занимается безопасностью приложений и API", "София Медведева", "Инженер по безопасности" },
                    { new Guid("f4000000-0000-0000-0000-000000000009"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Помогает командам на ранней стадии роста", "Павел Зорин", "Ментор стартапов" },
                    { new Guid("f4000000-0000-0000-0000-00000000000a"), "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Развивает инженерные и продуктовые сообщества", "Ольга Андреева", "Лид комьюнити" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "HashPassword", "LastName", "Major", "QrCode", "Role", "Updated" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ageev@gmail.com", "Леша", "$2a$11$gCAufVWeez3MDd8oFZQ7tONAwMSZAbvLeMXyNOYHOB1Ss5/n/eZXy", "Агеев", "IOS", "QR-11111111", "Employee", null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "budaeva@gmail.com", "Заята", "$2a$11$UQXeDxqmj0EWcvsKyox8Y..KyqJv2k4aLVuc5NGmoqjvijPDqn9oy", "Будаева", "Backend", "QR-33333333", "Client", null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "yaganova@gmail.com", "Маргарита", "$2a$11$Ob5I3TDKDEgWrF1adZjSx.p5FwWmZzpujQ6/VHuIFU3CfJhhLUTWK", "Яганова", "DevOps", "QR-44444444", "Client", null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ilyashova@gmail.com", "Настя", "$2a$11$vNqPxkGEGmhG1z.8ZR0vgu.AgFqKP84V12XHleGmbCdK4ACXOMQJu", "Ильяшова", "Flutter", "QR-55555555", "Client", null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "shakirov@gmail.com", "Ирек", "$2a$11$YXLD4kx1Ig91fzeqPDCHheUfYfF//2BSZcGcorZ0dvZtOJYbAX5xa", "Шакиров", "ML", "QR-66666666", "Client", null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "mescheryakov@gmail.com", "Сергей", "$2a$11$gXyWzFVta14QE2rumahQKeEtwwERMEAuWhSOgbl9c0Lg44kcI3amq", "Мещеряков", "Android", "QR-77777777", "Client", null }
                });

            migrationBuilder.InsertData(
                table: "UserAchievments",
                columns: new[] { "AchievmentsId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f6000000-0000-0000-0000-000000000001"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("f6000000-0000-0000-0000-000000000002"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("f6000000-0000-0000-0000-000000000003"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "Color", "CoordX", "CoordY", "Description", "FloorId", "Icon", "Title" },
                values: new object[,]
                {
                    { new Guid("f3000000-0000-0000-0000-000000000001"), "#2563EB", 0.10000000000000001, 0.20000000000000001, "Ключевые доклады и открытие", new Guid("f2000000-0000-0000-0000-000000000001"), "https://disk.yandex.ru/i/iKkOIrUSoGj94g", "Главная сцена" },
                    { new Guid("f3000000-0000-0000-0000-000000000002"), "#7C3AED", 0.29999999999999999, 0.14999999999999999, "Практические сессии и разборы", new Guid("f2000000-0000-0000-0000-000000000002"), "https://disk.yandex.ru/i/dpqf86-EPl3LZQ", "Зал воркшопов" },
                    { new Guid("f3000000-0000-0000-0000-000000000003"), "#059669", 0.45000000000000001, 0.25, "Консультации и карьерные треки", new Guid("f2000000-0000-0000-0000-000000000002"), "https://disk.yandex.ru/i/Brxe_BOEQLs4Uw", "Карьерная зона" },
                    { new Guid("f3000000-0000-0000-0000-000000000004"), "#DC2626", 0.20000000000000001, 0.34999999999999998, "Демо и стенды по ML", new Guid("f2000000-0000-0000-0000-000000000001"), "https://disk.yandex.ru/i/Brxe_BOEQLs4Uw", "Лаборатория ИИ" },
                    { new Guid("f3000000-0000-0000-0000-000000000005"), "#EA580C", 0.5, 0.10000000000000001, "iOS и Android практики", new Guid("f2000000-0000-0000-0000-000000000002"), "https://disk.yandex.ru/i/wJm1eOGLzPXgKA", "Мобильная точка" },
                    { new Guid("f3000000-0000-0000-0000-000000000006"), "#0F766E", 0.14999999999999999, 0.5, "Серверные технологии и архитектура", new Guid("f2000000-0000-0000-0000-000000000001"), "https://disk.yandex.ru/i/Mq_B4ltBwXqERA", "Бэкенд-комната" },
                    { new Guid("f3000000-0000-0000-0000-000000000007"), "#BE185D", 0.40000000000000002, 0.40000000000000002, "UX, интерфейсы и прототипы", new Guid("f2000000-0000-0000-0000-000000000002"), "https://disk.yandex.ru/i/NoBvNU5C1kyYHA", "Дизайн-уголок" },
                    { new Guid("f3000000-0000-0000-0000-000000000008"), "#334155", 0.34999999999999998, 0.55000000000000004, "Безопасная разработка и лучшие практики", new Guid("f2000000-0000-0000-0000-000000000001"), "https://disk.yandex.ru/i/SRL4it0fUb1Vyg", "Хаб безопасности" },
                    { new Guid("f3000000-0000-0000-0000-000000000009"), "#4F46E5", 0.55000000000000004, 0.29999999999999999, "Питчи, гипотезы и рост", new Guid("f2000000-0000-0000-0000-000000000002"), "https://disk.yandex.ru/i/vuHGvBAe5txuRAl", "Стартап-площадка" },
                    { new Guid("f3000000-0000-0000-0000-00000000000a"), "#16A34A", 0.25, 0.45000000000000001, "Нетворкинг и вопросы экспертам", new Guid("f2000000-0000-0000-0000-000000000001"), "https://disk.yandex.ru/i/6MvK-ECffChbPg", "Комьюнити-зона" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Category", "Description", "EndDateTime", "FestivalId", "StartDateTime", "StreamURL", "Title", "ZoneId" },
                values: new object[,]
                {
                    { new Guid("f5000000-0000-0000-0000-000000000001"), "Пленарный доклад", "Торжественное открытие конференции. Обзор платформы, основные возможности и план развития", new DateTime(2026, 6, 25, 9, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 8, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=TdnLjukE6Ws&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=1", "Вводная по платформе", new Guid("f3000000-0000-0000-0000-000000000001") },
                    { new Guid("f5000000-0000-0000-0000-000000000002"), "Доклад", "Первая часть углубленного курса по Swift. Изучаем продвинутые концепции и лучшие практики программирования на Swift", new DateTime(2026, 6, 25, 10, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 9, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=C2k_GzjdDQk&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=2", "Advanced Swift programming Part 1", new Guid("f3000000-0000-0000-0000-000000000002") },
                    { new Guid("f5000000-0000-0000-0000-000000000003"), "Кейс", "Вторая часть углубленного курса по Swift. Продолжение изучения сложных паттернов и оптимизации кода", new DateTime(2026, 6, 25, 11, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 10, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=XDZal1OUbrU&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=3", "Advanced Swift programming Part 2", new Guid("f3000000-0000-0000-0000-000000000003") },
                    { new Guid("f5000000-0000-0000-0000-000000000004"), "Воркшоп", "Введение в SwiftUI. Основы построения пользовательских интерфейсов с использованием декларативного подхода", new DateTime(2026, 6, 25, 12, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 11, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=NZ46DBOaUzc&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=4", "Basic SwiftUI", new Guid("f3000000-0000-0000-0000-000000000004") },
                    { new Guid("f5000000-0000-0000-0000-000000000005"), "Доклад", "Продвинутые техники в SwiftUI. Работа со сложными состояниями, анимациями и оптимизацией производительности", new DateTime(2026, 6, 25, 13, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 12, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=FPJNTfR6_J8&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=5", "Advanced SwiftUI", new Guid("f3000000-0000-0000-0000-000000000005") },
                    { new Guid("f5000000-0000-0000-0000-000000000006"), "Кейс", "Классический подход к разработке интерфейсов на iOS. Основные компоненты и практические примеры использования UIKit", new DateTime(2026, 6, 25, 14, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 13, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=1PdibPZQu7w&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=6", "UIKit", new Guid("f3000000-0000-0000-0000-000000000006") },
                    { new Guid("f5000000-0000-0000-0000-000000000007"), "Доклад", "Паттерны архитектуры приложений iOS. MVVM, VIPER, Clean Architecture и их применение в реальных проектах", new DateTime(2026, 6, 25, 15, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 14, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=qhG36NquE8M&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=7", "Архитектура", new Guid("f3000000-0000-0000-0000-000000000007") },
                    { new Guid("f5000000-0000-0000-0000-000000000008"), "Воркшоп", "Инструменты разработки для iOS. Xcode, системы управления зависимостями и оптимизация workflow разработчика", new DateTime(2026, 6, 25, 16, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 15, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=kJtf5InGOME&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=8", "IDE, Toolchain, Cocoapods/SPM", new Guid("f3000000-0000-0000-0000-000000000008") },
                    { new Guid("f5000000-0000-0000-0000-000000000009"), "Панель", "Основы многопоточности в Swift. Главная очередь, фоновые потоки и синхронизация данных", new DateTime(2026, 6, 25, 17, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 16, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=2sktj5cL4wg&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=9", "Basic Concurrency", new Guid("f3000000-0000-0000-0000-000000000009") },
                    { new Guid("f5000000-0000-0000-0000-00000000000a"), "Вопросы и ответы", "Продвинутые концепции многопоточности в Swift. Async/await, actors и обработка ошибок при асинхронной работе", new DateTime(2026, 6, 25, 20, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 17, 0, 0, 0, DateTimeKind.Utc), "https://www.youtube.com/watch?v=MKgtXIStCfk&list=PLXtiZNKIobF6Nj5wq6viExCgXELPZ55dA&index=10", "Advanced Concurrency", new Guid("f3000000-0000-0000-0000-00000000000a") }
                });

            migrationBuilder.InsertData(
                table: "EventSpeakers",
                columns: new[] { "EventsId", "SpeakersId" },
                values: new object[,]
                {
                    { new Guid("f5000000-0000-0000-0000-000000000001"), new Guid("f4000000-0000-0000-0000-000000000001") },
                    { new Guid("f5000000-0000-0000-0000-000000000002"), new Guid("f4000000-0000-0000-0000-000000000002") },
                    { new Guid("f5000000-0000-0000-0000-000000000003"), new Guid("f4000000-0000-0000-0000-000000000003") },
                    { new Guid("f5000000-0000-0000-0000-000000000004"), new Guid("f4000000-0000-0000-0000-000000000004") },
                    { new Guid("f5000000-0000-0000-0000-000000000005"), new Guid("f4000000-0000-0000-0000-000000000005") },
                    { new Guid("f5000000-0000-0000-0000-000000000006"), new Guid("f4000000-0000-0000-0000-000000000006") },
                    { new Guid("f5000000-0000-0000-0000-000000000007"), new Guid("f4000000-0000-0000-0000-000000000007") },
                    { new Guid("f5000000-0000-0000-0000-000000000008"), new Guid("f4000000-0000-0000-0000-000000000008") },
                    { new Guid("f5000000-0000-0000-0000-000000000009"), new Guid("f4000000-0000-0000-0000-000000000009") },
                    { new Guid("f5000000-0000-0000-0000-00000000000a"), new Guid("f4000000-0000-0000-0000-00000000000a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlackTokens_Token",
                table: "BlackTokens",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_FestivalId",
                table: "Events",
                column: "FestivalId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ZoneId",
                table: "Events",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeakers_SpeakersId",
                table: "EventSpeakers",
                column: "SpeakersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievments_UserId",
                table: "UserAchievments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLikedEvents_UserId",
                table: "UserLikedEvents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zones_FloorId",
                table: "Zones",
                column: "FloorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlackTokens");

            migrationBuilder.DropTable(
                name: "EventSpeakers");

            migrationBuilder.DropTable(
                name: "UserAchievments");

            migrationBuilder.DropTable(
                name: "UserLikedEvents");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Achievments");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Festivals");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Floors");
        }
    }
}
