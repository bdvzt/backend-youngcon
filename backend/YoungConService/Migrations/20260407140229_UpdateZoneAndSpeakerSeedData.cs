using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungConService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateZoneAndSpeakerSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000001"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Алексей Агеев", "Техлид команды мобильной разработки в Межгороде" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000002"),
                column: "FullName",
                value: "Андрей Сикерин");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000003"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Мария Журавлева", "HR manager" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000004"),
                column: "FullName",
                value: "Илья Соловьев");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000005"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Тимур Долозаткин", "iOS инженер Yandex Go" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000006"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Дима Деларю", "iOS-разработчик Yandex Go" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000007"),
                column: "FullName",
                value: "Антон Таранов");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000008"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Никикта Леванов", "iOS-разработчик Yandex Go" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000009"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Анастасия Талмазан", "Yandex Go SuperApp" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000001"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.66000000000000003, 0.47999999999999998 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000002"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.22, 0.11 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000003"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.25, 0.35999999999999999 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000004"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.52000000000000002, 0.080000000000000002 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000005"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.78000000000000003, 0.11 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000006"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.17999999999999999, 0.81999999999999995 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000007"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.71999999999999997, 0.81999999999999995 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000008"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.71999999999999997, 0.85999999999999999 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000009"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.75, 0.44 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-00000000000a"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.17999999999999999, 0.23000000000000001 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000001"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Степан Потапов", "iOS-разработчик команды плюса" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000002"),
                column: "FullName",
                value: "Мария Петрова");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000003"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Иван Волков", "ML-инженер" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000004"),
                column: "FullName",
                value: "Елена Сокол");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000005"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Никита Орлов", "Бэкенд-инженер" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000006"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Анна Белова", "Продакт-менеджер" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000007"),
                column: "FullName",
                value: "Дмитрий Егоров");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000008"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "София Медведева", "Инженер по безопасности" });

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000009"),
                columns: new[] { "FullName", "Job" },
                values: new object[] { "Павел Зорин", "Ментор стартапов" });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000001"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.10000000000000001, 0.20000000000000001 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000002"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.29999999999999999, 0.14999999999999999 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000003"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.45000000000000001, 0.25 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000004"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.20000000000000001, 0.34999999999999998 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000005"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.5, 0.10000000000000001 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000006"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.14999999999999999, 0.5 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000007"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.40000000000000002, 0.40000000000000002 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000008"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.34999999999999998, 0.55000000000000004 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-000000000009"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.55000000000000004, 0.29999999999999999 });

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("f3000000-0000-0000-0000-00000000000a"),
                columns: new[] { "CoordX", "CoordY" },
                values: new object[] { 0.25, 0.45000000000000001 });
        }
    }
}
