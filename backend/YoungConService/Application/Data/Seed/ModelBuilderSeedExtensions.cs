using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;

namespace YoungConService.Infrastructure.Repositories;

public static class ModelBuilderSeedExtensions
{
    public static void ApplyYoungConSeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(UserSeedData.Items);
        modelBuilder.Entity<Festival>().HasData(FestivalSeedData.Items);
        modelBuilder.Entity<Floor>().HasData(FloorSeedData.Items);
        modelBuilder.Entity<Zone>().HasData(ZoneSeedData.Items);
        modelBuilder.Entity<Speaker>().HasData(SpeakerSeedData.Items);
        modelBuilder.Entity<Event>().HasData(EventSeedData.Items);
        modelBuilder.Entity<Achievment>().HasData(AchievmentSeedData.Items);
    }
}
