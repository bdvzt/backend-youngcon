using YoungConService.Domain.Entities;
using YoungConService.Domain.Enums;

namespace YoungConService.Infrastructure.Repositories;

public static class UserSeedData
{
    private static readonly DateTime SeedCreatedAt = new(2026, 4, 1, 0, 0, 0, DateTimeKind.Utc);

    public static readonly User[] Items =
    {
        new()
        {
            Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            FirstName = "Леша",
            LastName = "Агеев",
            Email = "ageev@gmail.com",
            QrCode = "QR-11111111",
            Major = Major.Mobile,
            HashPassword = "$2a$11$gCAufVWeez3MDd8oFZQ7tONAwMSZAbvLeMXyNOYHOB1Ss5/n/eZXy",
            Role = UserRole.Employee,
            Created = SeedCreatedAt
        },
        new()
        {
            Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
            FirstName = "Заята",
            LastName = "Будаева",
            Email = "budaeva@gmail.com",
            QrCode = "QR-33333333",
            Major = Major.ML,
            HashPassword = "$2a$11$UQXeDxqmj0EWcvsKyox8Y..KyqJv2k4aLVuc5NGmoqjvijPDqn9oy",
            Role = UserRole.Client,
            Created = SeedCreatedAt
        },
        new()
        {
            Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
            FirstName = "Маргарита",
            LastName = "Яганова",
            Email = "yaganova@gmail.com",
            QrCode = "QR-44444444",
            Major = Major.DevOps,
            HashPassword = "$2a$11$Ob5I3TDKDEgWrF1adZjSx.p5FwWmZzpujQ6/VHuIFU3CfJhhLUTWK",
            Role = UserRole.Client,
            Created = SeedCreatedAt
        },
        new()
        {
            Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
            FirstName = "Настя",
            LastName = "Ильяшова",
            Email = "ilyashova@gmail.com",
            QrCode = "QR-55555555",
            Major = Major.Frontend,
            HashPassword = "$2a$11$vNqPxkGEGmhG1z.8ZR0vgu.AgFqKP84V12XHleGmbCdK4ACXOMQJu",
            Role = UserRole.Client,
            Created = SeedCreatedAt
        },
        new()
        {
            Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
            FirstName = "Ирек",
            LastName = "Шакиров",
            Email = "shakirov@gmail.com",
            QrCode = "QR-66666666",
            Major = Major.Frontend,
            HashPassword = "$2a$11$YXLD4kx1Ig91fzeqPDCHheUfYfF//2BSZcGcorZ0dvZtOJYbAX5xa",
            Role = UserRole.Client,
            Created = SeedCreatedAt
        },
        new()
        {
            Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
            FirstName = "Сергей",
            LastName = "Мещеряков",
            Email = "mescheryakov@gmail.com",
            QrCode = "QR-77777777",
            Major = Major.Mobile,
            HashPassword = "$2a$11$gXyWzFVta14QE2rumahQKeEtwwERMEAuWhSOgbl9c0Lg44kcI3amq",
            Role = UserRole.Client,
            Created = SeedCreatedAt
        }
    };
}
