using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UsersService.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "Created", "Email", "FirstName", "HashPassword", "LastName" },
                values: new object[] { new DateTime(2026, 3, 31, 14, 40, 41, 451, DateTimeKind.Utc).AddTicks(4770), "ageev@gmail.com", "Леша", "$2a$11$8VKnCG5FEC0AieuMTDplsOuVjch35WTrL.lmvJ5aQ7F/RQeC2svtO", "Агеев" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "Created", "Email", "FirstName", "HashPassword", "LastName" },
                values: new object[] { new DateTime(2026, 3, 31, 14, 40, 41, 451, DateTimeKind.Utc).AddTicks(4770), "budaeva@gmail.com", "Заята", "$2a$11$FzevHL6vVUo5h/XPus/erODBeGB.3yye2egUyQynoPttkSsgoySKa", "Будаева" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "Created", "Email", "FirstName", "HashPassword", "LastName" },
                values: new object[] { new DateTime(2026, 3, 31, 14, 40, 41, 451, DateTimeKind.Utc).AddTicks(4770), "yaganova@gmail.com", "Маргарита", "$2a$11$HnIKl653ofLi.PDwIAnu..tVt1nP.3CFckgs9.V9TvKaaM7lsMJZW", "Яганова" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "Created", "Email", "FirstName", "HashPassword", "LastName" },
                values: new object[] { new DateTime(2026, 3, 31, 14, 40, 41, 451, DateTimeKind.Utc).AddTicks(4770), "ilyashova@gmail.com", "Настя", "$2a$11$HcuxDPVHqQy0czV2vs4w7OdL2BEiQANc7UJ5rBG5t8syZBBOPrBA2", "Ильяшова" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "HashPassword", "LastName", "Role", "Updated" },
                values: new object[,]
                {
                    { new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 3, 31, 14, 40, 41, 451, DateTimeKind.Utc).AddTicks(4770), "shakirov@gmail.com", "Ирек", "$2a$11$BFeT8egiAf5AY1M65Tf5suoWhEaYPpHuMqawF2kWIOi/ScFXyWfCC", "Шакиров", 0, null },
                    { new Guid("77777777-7777-7777-7777-777777777777"), new DateTime(2026, 3, 31, 14, 40, 41, 451, DateTimeKind.Utc).AddTicks(4770), "mescheryakov@gmail.com", "Сергей", "$2a$11$14tp6eaTuZCC38eTroKpuO06VKPukr3wjtETn04PvIt5ROP/eorQS", "Мещеряков", 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Birthday",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "Birthday", "Created", "Email", "FirstName", "HashPassword", "IsBlocked", "LastName", "MiddleName", "Phone" },
                values: new object[] { new DateOnly(1990, 1, 1), new DateTime(2026, 2, 21, 13, 35, 43, 837, DateTimeKind.Utc).AddTicks(6160), "employee1@bank.ru", "Ivan", "12345678", false, "Petrov", "Ivanovich", "+79990000001" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "Birthday", "Created", "Email", "FirstName", "HashPassword", "IsBlocked", "LastName", "MiddleName", "Phone" },
                values: new object[] { new DateOnly(1995, 3, 3), new DateTime(2026, 2, 21, 13, 35, 43, 837, DateTimeKind.Utc).AddTicks(6160), "client1@bank.ru", "Alexey", "12345678", false, "Smirnov", "Sergeevich", "+79990000003" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "Birthday", "Created", "Email", "FirstName", "HashPassword", "IsBlocked", "LastName", "MiddleName", "Phone" },
                values: new object[] { new DateOnly(1998, 4, 4), new DateTime(2026, 2, 21, 13, 35, 43, 837, DateTimeKind.Utc).AddTicks(6160), "client2@bank.ru", "Maria", "12345678", false, "Ivanova", "Alexandrovna", "+79990000004" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "Birthday", "Created", "Email", "FirstName", "HashPassword", "IsBlocked", "LastName", "MiddleName", "Phone" },
                values: new object[] { new DateOnly(2000, 5, 5), new DateTime(2026, 2, 21, 13, 35, 43, 837, DateTimeKind.Utc).AddTicks(6160), "client3@bank.ru", "Dmitry", "12345678", false, "Kozlov", "Igorevich", "+79990000005" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "Created", "Email", "FirstName", "HashPassword", "IsBlocked", "LastName", "MiddleName", "Phone", "Role", "Updated" },
                values: new object[] { new Guid("22222222-2222-2222-2222-222222222222"), new DateOnly(1992, 2, 2), new DateTime(2026, 2, 21, 13, 35, 43, 837, DateTimeKind.Utc).AddTicks(6160), "employee2@bank.ru", "Anna", "12345678", false, "Sidorova", "Petrovna", "+79990000002", 1, null });
        }
    }
}
