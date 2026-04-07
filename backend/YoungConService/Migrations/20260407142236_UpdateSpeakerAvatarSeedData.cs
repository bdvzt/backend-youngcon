using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungConService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSpeakerAvatarSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000001"),
                column: "AvatarURL",
                value: "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.31.jpeg");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000003"),
                column: "AvatarURL",
                value: "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.25.jpeg");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000004"),
                column: "AvatarURL",
                value: "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.08.30.jpeg");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000005"),
                column: "AvatarURL",
                value: "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.12.jpeg");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000006"),
                column: "AvatarURL",
                value: "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.38.jpeg");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000007"),
                column: "AvatarURL",
                value: "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.09.44.jpeg");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000008"),
                column: "AvatarURL",
                value: "https://storage.yandexcloud.net/youngcon/photo_2026-04-07%2017.08.55.jpeg");

            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000009"),
                column: "AvatarURL",
                value: "https://storage.yandexcloud.net/youngcon/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%C2%A0%E2%80%94%202026-04-07%20%D0%B2%C2%A017.10.48.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Speakers",
                keyColumn: "Id",
                keyValue: new Guid("f4000000-0000-0000-0000-000000000001"),
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
        }
    }
}
