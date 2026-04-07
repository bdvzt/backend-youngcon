using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.Domain.Enums;

namespace YoungConService.Infrastructure.Repositories;

public class YoungConDbContext(DbContextOptions<YoungConDbContext> options) : DbContext(options)
{
    // Users & Auth
    public DbSet<User> Users => Set<User>();
    public DbSet<BlackToken> BlackTokens { get; set; } = null!;
    public DbSet<Achievment> Achievments { get; set; } = null!;

    // Events
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<Festival> Festivals { get; set; } = null!;
    public DbSet<Floor> Floors { get; set; } = null!;
    public DbSet<Zone> Zones { get; set; } = null!;
    public DbSet<Speaker> Speakers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // ===== Users Configuration =====
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.HasIndex(u => u.Email).IsUnique();
            entity.Property(u => u.FirstName).IsRequired().HasMaxLength(100);
            entity.Property(u => u.LastName).IsRequired().HasMaxLength(100);
            entity.Property(u => u.Email).IsRequired().HasMaxLength(255);
            entity.Property(u => u.QrCode).IsRequired();
            entity.Property(u => u.HashPassword).IsRequired();
            entity.Property(u => u.Role).HasConversion<string>();
            entity.Property(u => u.Major).HasConversion<string>();
        });

        // ===== BlackToken Configuration =====
        modelBuilder.Entity<BlackToken>(entity =>
        {
            entity.ToTable("BlackTokens");
            entity.HasKey(b => b.Id);
            entity.Property(b => b.Token).IsRequired();
            entity.HasIndex(b => b.Token).IsUnique();
            entity.Property(b => b.ExpiryDate).IsRequired();
        });

        // ===== Achievment Configuration =====
        modelBuilder.Entity<Achievment>(entity =>
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Name).IsRequired();
            entity.Property(a => a.Description).IsRequired();
            entity.Property(a => a.Icon).IsRequired();
            entity.Property(a => a.Color).IsRequired();
        });

        // User <-> Achievment (many-to-many)
        modelBuilder.Entity<User>()
            .HasMany(u => u.Achievments)
            .WithMany()
            .UsingEntity<Dictionary<string, object>>(
                "UserAchievments",
                right => right.HasOne<Achievment>().WithMany().HasForeignKey("AchievmentsId").OnDelete(DeleteBehavior.Cascade),
                left => left.HasOne<User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.Cascade),
                join =>
                {
                    join.HasKey("AchievmentsId", "UserId");
                    join.ToTable("UserAchievments");
                    join.HasData(UserAchievmentSeedData.Items);
                });

        // User <-> Event (LikedEvents, many-to-many)
        modelBuilder.Entity<User>()
            .HasMany(u => u.LikedEvents)
            .WithMany()
            .UsingEntity(j => j.ToTable("UserLikedEvents"));

        // ===== Festival Configuration =====
        modelBuilder.Entity<Festival>(entity =>
        {
            entity.HasKey(f => f.Id);
            entity.Property(f => f.Title).IsRequired();
            entity.Property(f => f.Description).IsRequired();
        });

        modelBuilder.Entity<Festival>()
            .HasMany(f => f.Events)
            .WithOne(e => e.Festival)
            .HasForeignKey(e => e.FestivalId)
            .OnDelete(DeleteBehavior.Cascade);

        // ===== Floor Configuration =====
        modelBuilder.Entity<Floor>(entity =>
        {
            entity.HasKey(f => f.Id);
            entity.Property(f => f.Title).IsRequired();
            entity.Property(f => f.MapURL).IsRequired();
        });

        modelBuilder.Entity<Floor>()
            .HasMany(f => f.Zones)
            .WithOne(z => z.Floor)
            .HasForeignKey(z => z.FloorId)
            .OnDelete(DeleteBehavior.Cascade);

        // ===== Zone Configuration =====
        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(z => z.Id);
            entity.Property(z => z.Title).IsRequired();
            entity.Property(z => z.Description).IsRequired();
            entity.Property(z => z.Icon).IsRequired();
            entity.Property(z => z.Color).IsRequired();
        });

        // ===== Speaker Configuration =====
        modelBuilder.Entity<Speaker>(entity =>
        {
            entity.HasKey(s => s.Id);
            entity.Property(s => s.FullName).IsRequired();
            entity.Property(s => s.Job).IsRequired();
            entity.Property(s => s.Bio).IsRequired();
            entity.Property(s => s.AvatarURL).IsRequired();
        });

        modelBuilder.Entity<Event>()
            .HasMany(e => e.Speakers)
            .WithMany(s => s.Events)
            .UsingEntity<Dictionary<string, object>>(
                "EventSpeakers",
                right => right.HasOne<Speaker>().WithMany().HasForeignKey("SpeakersId").OnDelete(DeleteBehavior.Cascade),
                left => left.HasOne<Event>().WithMany().HasForeignKey("EventsId").OnDelete(DeleteBehavior.Cascade),
                join =>
                {
                    join.HasKey("EventsId", "SpeakersId");
                    join.ToTable("EventSpeakers");
                    join.HasData(EventSpeakerSeedData.Items);
                });

        // ===== Event Configuration =====
        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired();
            entity.Property(e => e.Description).IsRequired();
            entity.Property(e => e.Category).IsRequired();
        });

        modelBuilder.Entity<Event>()
            .HasOne(e => e.Zone)
            .WithMany()
            .HasForeignKey(e => e.ZoneId)
            .OnDelete(DeleteBehavior.Cascade);

        // Seed вынесен в отдельные файлы в этой же папке.
        modelBuilder.ApplyYoungConSeedData();
    }
}