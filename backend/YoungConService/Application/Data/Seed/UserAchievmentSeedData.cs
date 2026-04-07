namespace YoungConService.Infrastructure.Repositories;

public static class UserAchievmentSeedData
{
    public static readonly object[] Items =
    {
        new
        {
            AchievmentsId = Guid.Parse("f6000000-0000-0000-0000-000000000001"),
            UserId = Guid.Parse("44444444-4444-4444-4444-444444444444")
        },
        new
        {
            AchievmentsId = Guid.Parse("f6000000-0000-0000-0000-000000000002"),
            UserId = Guid.Parse("44444444-4444-4444-4444-444444444444")
        },
        new
        {
            AchievmentsId = Guid.Parse("f6000000-0000-0000-0000-000000000003"),
            UserId = Guid.Parse("44444444-4444-4444-4444-444444444444")
        }
    };
}

