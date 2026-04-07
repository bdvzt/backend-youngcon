using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungConService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllSeedDataApr07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000001"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#FF87BB", "Отсканируй бейдж при входе и окажись среди первых 30 участников фестиваля.", "https://storage.yandexcloud.net/youngcon/first.png", "Ранняя пташка" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000002"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#C59EFF", "Отсканируй бейдж на одной из лекций.", "https://storage.yandexcloud.net/youngcon/headphones.png", "Слушатель" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000003"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#FCFF72", "Отсканируй бейдж в кофе-поинте и получи фирменный напиток от партнёров.", "https://storage.yandexcloud.net/youngcon/coffee1.png", "Кофеман" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000004"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#FF87BB", "Обменяйся контактами с 3 разными участниками и отсканируй бейдж в комьюнити-зоне.", "https://storage.yandexcloud.net/youngcon/network.png", "Нетворкер" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000005"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#C59EFF", "Побывайте на прямой трансляции с МКС.", "https://storage.yandexcloud.net/youngcon/mks.png", "Поехали" });

            migrationBuilder.InsertData(
                table: "Achievments",
                columns: new[] { "Id", "Color", "Description", "Icon", "Name" },
                values: new object[] { new Guid("f6000000-0000-0000-0000-000000000006"), "#FCFF72", "Пройти Fast Track и получи приглашение на собеседование.", "https://storage.yandexcloud.net/youngcon/offer.png", "Оффер в кармане" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000001"),
                column: "Category",
                value: "Лекция");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000002"),
                column: "Category",
                value: "Лекция");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000003"),
                column: "Category",
                value: "Лекция");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000004"),
                column: "Category",
                value: "Лекция");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000005"),
                column: "Category",
                value: "Воркшоп");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000006"),
                column: "Category",
                value: "Лекция");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000007"),
                column: "Category",
                value: "Лекция");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000009"),
                column: "Category",
                value: "Лекция");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-00000000000a"),
                column: "Category",
                value: "Воркшоп");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000001"),
                column: "Bio",
                value: "Руководит мобильной разработкой, выстраивает архитектуру iOS-приложений и процессы команды.");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000002"),
                columns: new[] { "Bio", "Job" },
                values: new object[] { "Разрабатывает и оптимизирует iOS-фичи браузера, улучшает производительность и пользовательский опыт.", "iOS-разработчик в Yandex Browser" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000003"),
                column: "Bio",
                value: "Отвечает за найм и развитие инженерных команд, сопровождает карьерные треки специалистов.");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000004"),
                columns: new[] { "Bio", "Job" },
                values: new object[] { "Занимается клиентской разработкой iOS-приложения и внедряет новые продуктовые сценарии.", "iOS-разработчик в Yandex Browser" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000005"),
                column: "Bio",
                value: "Разрабатывает ключевые iOS-компоненты Yandex Go и поддерживает стабильность релизов.");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000006"),
                column: "Bio",
                value: "Фокусируется на продуктовых iOS-фичах, улучшает качество кода и пользовательский опыт.");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000007"),
                columns: new[] { "Bio", "Job" },
                values: new object[] { "Разрабатывает iOS-модули SuperApp и интеграции между сервисами.", "iOS-разработчик SuperApp" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000008"),
                column: "Bio",
                value: "Работает над iOS-архитектурой и инфраструктурой приложения, повышает надежность клиентской части.");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000009"),
                columns: new[] { "Bio", "Job" },
                values: new object[] { "Отвечает за развитие iOS-функциональности SuperApp и быстрый запуск новых сценариев.", "iOS-разработчик SuperApp" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-00000000000a"),
                columns: new[] { "AvatarURL", "Bio", "FullName", "Job" },
                values: new object[] { "https://storage.yandexcloud.net/youngcon/stepan.png", "Развивает iOS-приложение Yandex Plus, работает над подписочными и медиасценариями.", "Степан Потапов", "iOS-разработчик Yandex Plus" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000001"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#FF87BB", "https://storage.yandexcloud.net/youngcon/scene.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000002"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#FCFF72", "https://storage.yandexcloud.net/youngcon/work.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000003"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#FCFF72", "https://storage.yandexcloud.net/youngcon/career.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000004"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#C59EFF", "https://storage.yandexcloud.net/youngcon/ai.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000005"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#C59EFF", "https://storage.yandexcloud.net/youngcon/phome.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000006"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#C59EFF", "https://storage.yandexcloud.net/youngcon/server.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000007"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#FCFF72", "https://storage.yandexcloud.net/youngcon/design.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000008"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#C59EFF", "https://storage.yandexcloud.net/youngcon/shield.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000009"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#FF87BB", "https://storage.yandexcloud.net/youngcon/rocket.png" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-00000000000a"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#FF87BB", "https://storage.yandexcloud.net/youngcon/networking.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000006"));

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000001"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#2563EB", "Первый вход в приложение", "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", "КВЕСТ ПРОЙДЕН" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000002"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#7C3AED", "Просмотрено 5 событий", "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", "КОФЕМАН" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000003"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#DC2626", "Добавлен первый фестиваль в избранное", "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", "НЕТВОРКЕР" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000004"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#16A34A", "Проведен весь день на фестивале (11:00–23:00)", "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", "ЦЕЛЫЙ ДЕНЬ" });

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000005"),
                columns: new[] { "Color", "Description", "Icon", "Name" },
                values: new object[] { "#EA580C", "Прослушано 3 доклада", "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png", "ОФФЕР В КАРМАНЕ!" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000001"),
                column: "Category",
                value: "Пленарный доклад");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000002"),
                column: "Category",
                value: "Доклад");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000003"),
                column: "Category",
                value: "Кейс");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000004"),
                column: "Category",
                value: "Воркшоп");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000005"),
                column: "Category",
                value: "Доклад");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000006"),
                column: "Category",
                value: "Кейс");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000007"),
                column: "Category",
                value: "Доклад");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-000000000009"),
                column: "Category",
                value: "Панель");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f5000000-0000-0000-0000-00000000000a"),
                column: "Category",
                value: "Вопросы и ответы");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000001"),
                column: "Bio",
                value: "15 лет развивает веб-платформы и клиентские архитектуры");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000002"),
                columns: new[] { "Bio", "Job" },
                values: new object[] { "Создает мобильные приложения для миллионов пользователей", "Техлид мобильной разработки" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000003"),
                column: "Bio",
                value: "Проектирует рекомендательные и поисковые модели");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000004"),
                columns: new[] { "Bio", "Job" },
                values: new object[] { "Автоматизирует облачную инфраструктуру и релизы", "DevOps-архитектор" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000005"),
                column: "Bio",
                value: "Специализируется на распределенных сервисах");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000006"),
                column: "Bio",
                value: "Ведет кросс-функциональные продуктовые команды");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000007"),
                columns: new[] { "Bio", "Job" },
                values: new object[] { "Проектирует интерфейсы на основе пользовательских данных", "UX-дизайнер" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000008"),
                column: "Bio",
                value: "Занимается безопасностью приложений и API");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000009"),
                columns: new[] { "Bio", "Job" },
                values: new object[] { "Помогает командам на ранней стадии роста", "Yandex Go SuperApp" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-00000000000a"),
                columns: new[] { "AvatarURL", "Bio", "FullName", "Job" },
                values: new object[] { "https://disk.yandex.ru/i/UQpqThhyd6LYiw", "Развивает инженерные и продуктовые сообщества", "Ольга Андреева", "Лид комьюнити" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000001"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#2563EB", "https://disk.yandex.ru/i/iKkOIrUSoGj94g" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000002"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#7C3AED", "https://disk.yandex.ru/i/dpqf86-EPl3LZQ" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000003"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#059669", "https://disk.yandex.ru/i/Brxe_BOEQLs4Uw" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000004"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#DC2626", "https://disk.yandex.ru/i/Brxe_BOEQLs4Uw" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000005"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#EA580C", "https://disk.yandex.ru/i/wJm1eOGLzPXgKA" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000006"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#0F766E", "https://disk.yandex.ru/i/Mq_B4ltBwXqERA" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000007"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#BE185D", "https://disk.yandex.ru/i/NoBvNU5C1kyYHA" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000008"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#334155", "https://disk.yandex.ru/i/SRL4it0fUb1Vyg" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000009"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#4F46E5", "https://disk.yandex.ru/i/vuHGvBAe5txuRAl" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-00000000000a"),
                columns: new[] { "Color", "Icon" },
                values: new object[] { "#16A34A", "https://disk.yandex.ru/i/6MvK-ECffChbPg" });
        }
    }
}
