using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungConService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAchievmentsAndFloorsIcons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000001"),
                column: "Icon",
                value: "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000002"),
                column: "Icon",
                value: "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000003"),
                column: "Icon",
                value: "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000004"),
                column: "Icon",
                value: "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000005"),
                column: "Icon",
                value: "https://storage.yandexcloud.net/youngcon/free-icon-bird-roadrunner-shape-47127%20(1).png");

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("f2000000-0000-0000-0000-000000000001"),
                column: "MapURL",
                value: "https://storage.yandexcloud.net/youngcon/FirstFloor.png");

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("f2000000-0000-0000-0000-000000000002"),
                column: "MapURL",
                value: "https://storage.yandexcloud.net/youngcon/SecondFloor.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000001"),
                column: "Icon",
                value: "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000002"),
                column: "Icon",
                value: "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000003"),
                column: "Icon",
                value: "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000004"),
                column: "Icon",
                value: "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g");

            migrationBuilder.UpdateData(
                table: "Achievments",
                keyColumn: "Id",
                keyValue: new Guid("f6000000-0000-0000-0000-000000000005"),
                column: "Icon",
                value: "https://disk.yandex.ru/i/wm2ZLP7FfpWW7g");

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("f2000000-0000-0000-0000-000000000001"),
                column: "MapURL",
                value: "https://youngcon.local/maps/floor-1");

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("f2000000-0000-0000-0000-000000000002"),
                column: "MapURL",
                value: "https://youngcon.local/maps/floor-2");
        }
    }
}
