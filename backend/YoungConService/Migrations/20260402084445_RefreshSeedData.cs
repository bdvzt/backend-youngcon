using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoungConService.Migrations
{
    /// <inheritdoc />
    public partial class RefreshSeedData : Migration
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
                    Category = table.Column<string>(type: "text", nullable: false)
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
                    { new Guid("f6000000-0000-0000-0000-000000000001"), "#2563EB", "Первый вход в приложение", "star.fill", "Первый вход" },
                    { new Guid("f6000000-0000-0000-0000-000000000002"), "#7C3AED", "Просмотрено 5 событий", "safari.fill", "Исследователь" },
                    { new Guid("f6000000-0000-0000-0000-000000000003"), "#DC2626", "Добавлен первый фестиваль в избранное", "heart.fill", "Фестивальный фанат" },
                    { new Guid("f6000000-0000-0000-0000-000000000004"), "#16A34A", "Посещено 3 зоны общения", "person.3.fill", "Нетворкер" },
                    { new Guid("f6000000-0000-0000-0000-000000000005"), "#EA580C", "Прослушано 3 доклада", "mic.fill", "Внимательный слушатель" },
                    { new Guid("f6000000-0000-0000-0000-000000000006"), "#0F766E", "Участие в 2 воркшопах", "wrench.and.screwdriver.fill", "Герой воркшопов" },
                    { new Guid("f6000000-0000-0000-0000-000000000007"), "#334155", "Пройден трек по безопасности", "lock.shield.fill", "Безопасный подход" },
                    { new Guid("f6000000-0000-0000-0000-000000000008"), "#BE185D", "Посещение продуктовой сессии", "lightbulb.fill", "Продуктовое мышление" },
                    { new Guid("f6000000-0000-0000-0000-000000000009"), "#4F46E5", "Посещение дизайн-зоны", "paintpalette.fill", "Чувство дизайна" },
                    { new Guid("f6000000-0000-0000-0000-00000000000a"), "#059669", "Полный день на фестивале", "calendar.badge.clock", "Целый день" }
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
                    { new Guid("f4000000-0000-0000-0000-000000000001"), "https://youngcon.local/avatars/speaker-1.png", "15 лет развивает веб-платформы и клиентские архитектуры", "Алексей Смирнов", "Старший фронтенд-инженер" },
                    { new Guid("f4000000-0000-0000-0000-000000000002"), "https://youngcon.local/avatars/speaker-2.png", "Создает мобильные приложения для миллионов пользователей", "Мария Петрова", "Техлид мобильной разработки" },
                    { new Guid("f4000000-0000-0000-0000-000000000003"), "https://youngcon.local/avatars/speaker-3.png", "Проектирует рекомендательные и поисковые модели", "Иван Волков", "ML-инженер" },
                    { new Guid("f4000000-0000-0000-0000-000000000004"), "https://youngcon.local/avatars/speaker-4.png", "Автоматизирует облачную инфраструктуру и релизы", "Елена Сокол", "DevOps-архитектор" },
                    { new Guid("f4000000-0000-0000-0000-000000000005"), "https://youngcon.local/avatars/speaker-5.png", "Специализируется на распределенных сервисах", "Никита Орлов", "Бэкенд-инженер" },
                    { new Guid("f4000000-0000-0000-0000-000000000006"), "https://youngcon.local/avatars/speaker-6.png", "Ведет кросс-функциональные продуктовые команды", "Анна Белова", "Продакт-менеджер" },
                    { new Guid("f4000000-0000-0000-0000-000000000007"), "https://youngcon.local/avatars/speaker-7.png", "Проектирует интерфейсы на основе пользовательских данных", "Дмитрий Егоров", "UX-дизайнер" },
                    { new Guid("f4000000-0000-0000-0000-000000000008"), "https://youngcon.local/avatars/speaker-8.png", "Занимается безопасностью приложений и API", "София Медведева", "Инженер по безопасности" },
                    { new Guid("f4000000-0000-0000-0000-000000000009"), "https://youngcon.local/avatars/speaker-9.png", "Помогает командам на ранней стадии роста", "Павел Зорин", "Ментор стартапов" },
                    { new Guid("f4000000-0000-0000-0000-00000000000a"), "https://youngcon.local/avatars/speaker-10.png", "Развивает инженерные и продуктовые сообщества", "Ольга Андреева", "Лид комьюнити" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "HashPassword", "LastName", "Major", "QrCode", "Role", "Updated" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ageev@gmail.com", "Леша", "$2a$11$gCAufVWeez3MDd8oFZQ7tONAwMSZAbvLeMXyNOYHOB1Ss5/n/eZXy", "Агеев", "Mobile", "QR-11111111", "Employee", null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "budaeva@gmail.com", "Заята", "$2a$11$UQXeDxqmj0EWcvsKyox8Y..KyqJv2k4aLVuc5NGmoqjvijPDqn9oy", "Будаева", "ML", "QR-33333333", "Client", null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "yaganova@gmail.com", "Маргарита", "$2a$11$Ob5I3TDKDEgWrF1adZjSx.p5FwWmZzpujQ6/VHuIFU3CfJhhLUTWK", "Яганова", "DevOps", "QR-44444444", "Client", null },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ilyashova@gmail.com", "Настя", "$2a$11$vNqPxkGEGmhG1z.8ZR0vgu.AgFqKP84V12XHleGmbCdK4ACXOMQJu", "Ильяшова", "Frontend", "QR-55555555", "Client", null },
                    { new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "shakirov@gmail.com", "Ирек", "$2a$11$YXLD4kx1Ig91fzeqPDCHheUfYfF//2BSZcGcorZ0dvZtOJYbAX5xa", "Шакиров", "Frontend", "QR-66666666", "Client", null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "mescheryakov@gmail.com", "Сергей", "$2a$11$gXyWzFVta14QE2rumahQKeEtwwERMEAuWhSOgbl9c0Lg44kcI3amq", "Мещеряков", "Mobile", "QR-77777777", "Client", null }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "Color", "Description", "FloorId", "Icon", "Title" },
                values: new object[,]
                {
                    { new Guid("f3000000-0000-0000-0000-000000000001"), "#2563EB", "Ключевые доклады и открытие", new Guid("f2000000-0000-0000-0000-000000000001"), "sparkles.rectangle.stack.fill", "Главная сцена" },
                    { new Guid("f3000000-0000-0000-0000-000000000002"), "#7C3AED", "Практические сессии и разборы", new Guid("f2000000-0000-0000-0000-000000000002"), "hammer.fill", "Зал воркшопов" },
                    { new Guid("f3000000-0000-0000-0000-000000000003"), "#059669", "Консультации и карьерные треки", new Guid("f2000000-0000-0000-0000-000000000002"), "briefcase.fill", "Карьерная зона" },
                    { new Guid("f3000000-0000-0000-0000-000000000004"), "#DC2626", "Демо и стенды по ML", new Guid("f2000000-0000-0000-0000-000000000001"), "brain.head.profile", "Лаборатория ИИ" },
                    { new Guid("f3000000-0000-0000-0000-000000000005"), "#EA580C", "iOS и Android практики", new Guid("f2000000-0000-0000-0000-000000000002"), "iphone.gen3", "Мобильная точка" },
                    { new Guid("f3000000-0000-0000-0000-000000000006"), "#0F766E", "Серверные технологии и архитектура", new Guid("f2000000-0000-0000-0000-000000000001"), "server.rack", "Бэкенд-комната" },
                    { new Guid("f3000000-0000-0000-0000-000000000007"), "#BE185D", "UX, интерфейсы и прототипы", new Guid("f2000000-0000-0000-0000-000000000002"), "paintpalette.fill", "Дизайн-уголок" },
                    { new Guid("f3000000-0000-0000-0000-000000000008"), "#334155", "Безопасная разработка и лучшие практики", new Guid("f2000000-0000-0000-0000-000000000001"), "shield.lefthalf.filled", "Хаб безопасности" },
                    { new Guid("f3000000-0000-0000-0000-000000000009"), "#4F46E5", "Питчи, гипотезы и рост", new Guid("f2000000-0000-0000-0000-000000000002"), "paperplane.fill", "Стартап-площадка" },
                    { new Guid("f3000000-0000-0000-0000-00000000000a"), "#16A34A", "Нетворкинг и вопросы экспертам", new Guid("f2000000-0000-0000-0000-000000000001"), "person.3.fill", "Комьюнити-зона" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Category", "Description", "EndDateTime", "FestivalId", "StartDateTime", "Title", "ZoneId" },
                values: new object[,]
                {
                    { new Guid("f5000000-0000-0000-0000-000000000001"), "Пленарный доклад", "Торжественное открытие фестиваля", new DateTime(2026, 6, 25, 9, 30, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 6, 25, 8, 30, 0, 0, DateTimeKind.Utc), "Открывающий доклад", new Guid("f3000000-0000-0000-0000-000000000001") },
                    { new Guid("f5000000-0000-0000-0000-000000000002"), "Доклад", "Тренды и инструменты мобильной экосистемы", new DateTime(2026, 7, 2, 11, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 7, 2, 10, 0, 0, 0, DateTimeKind.Utc), "Состояние мобильной разработки", new Guid("f3000000-0000-0000-0000-000000000002") },
                    { new Guid("f5000000-0000-0000-0000-000000000003"), "Кейс", "Практика внедрения моделей в продукты", new DateTime(2026, 7, 9, 12, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 7, 9, 11, 0, 0, 0, DateTimeKind.Utc), "ML в продакшене", new Guid("f3000000-0000-0000-0000-000000000003") },
                    { new Guid("f5000000-0000-0000-0000-000000000004"), "Воркшоп", "Подходы к стабильным релизам", new DateTime(2026, 7, 16, 13, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 7, 16, 12, 0, 0, 0, DateTimeKind.Utc), "Шаблоны CI/CD", new Guid("f3000000-0000-0000-0000-000000000004") },
                    { new Guid("f5000000-0000-0000-0000-000000000005"), "Доклад", "Проектирование отказоустойчивых интерфейсов", new DateTime(2026, 7, 23, 14, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 7, 23, 13, 0, 0, 0, DateTimeKind.Utc), "Надежные API", new Guid("f3000000-0000-0000-0000-000000000005") },
                    { new Guid("f5000000-0000-0000-0000-000000000006"), "Кейс", "Как находить и проверять гипотезы", new DateTime(2026, 7, 30, 15, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 7, 30, 14, 0, 0, 0, DateTimeKind.Utc), "Поиск продуктовой ценности", new Guid("f3000000-0000-0000-0000-000000000006") },
                    { new Guid("f5000000-0000-0000-0000-000000000007"), "Доклад", "Системный подход к интерфейсам", new DateTime(2026, 8, 6, 12, 30, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 8, 6, 11, 30, 0, 0, DateTimeKind.Utc), "Дизайн-системы", new Guid("f3000000-0000-0000-0000-000000000007") },
                    { new Guid("f5000000-0000-0000-0000-000000000008"), "Воркшоп", "Безопасная разработка на каждом этапе", new DateTime(2026, 8, 13, 13, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 8, 13, 12, 0, 0, 0, DateTimeKind.Utc), "Безопасность по умолчанию", new Guid("f3000000-0000-0000-0000-000000000008") },
                    { new Guid("f5000000-0000-0000-0000-000000000009"), "Панель", "Типичные ошибки ранних стадий", new DateTime(2026, 8, 20, 14, 30, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 8, 20, 13, 30, 0, 0, DateTimeKind.Utc), "Ошибки стартапов", new Guid("f3000000-0000-0000-0000-000000000009") },
                    { new Guid("f5000000-0000-0000-0000-00000000000a"), "Вопросы и ответы", "Вопросы и ответы с экспертами", new DateTime(2026, 8, 27, 17, 0, 0, 0, DateTimeKind.Utc), new Guid("f1000000-0000-0000-0000-000000000001"), new DateTime(2026, 8, 27, 16, 0, 0, 0, DateTimeKind.Utc), "Открытый микрофон", new Guid("f3000000-0000-0000-0000-00000000000a") }
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
