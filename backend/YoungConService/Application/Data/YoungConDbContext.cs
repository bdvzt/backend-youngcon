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
            .UsingEntity(j => j.ToTable("UserAchievments"));

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

        modelBuilder.Entity<Speaker>()
            .HasMany(s => s.Events)
            .WithOne(e => e.Speaker)
            .HasForeignKey(e => e.SpeakerId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

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

        // ===== Seed Data =====
        var now = new DateTime(2026, 4, 1, 0, 0, 0, DateTimeKind.Utc);

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                FirstName = "Леша",
                LastName = "Агеев",
                Email = "ageev@gmail.com",
                QrCode = "QR-11111111",
                Major = Major.Frontend,
                HashPassword = BCrypt.Net.BCrypt.HashPassword("12345678"),
                Role = UserRole.Employee,
                Created = now
            },
            new User
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                FirstName = "Заята",
                LastName = "Будаева",
                Email = "budaeva@gmail.com",
                QrCode = "QR-33333333",
                Major = Major.Mobile,
                HashPassword = BCrypt.Net.BCrypt.HashPassword("12345678"),
                Role = UserRole.Client,
                Created = now
            },
            new User
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                FirstName = "Маргарита",
                LastName = "Яганова",
                Email = "yaganova@gmail.com",
                QrCode = "QR-44444444",
                Major = Major.ML,
                HashPassword = BCrypt.Net.BCrypt.HashPassword("12345678"),
                Role = UserRole.Client,
                Created = now
            },
            new User
            {
                Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                FirstName = "Настя",
                LastName = "Ильяшова",
                Email = "ilyashova@gmail.com",
                QrCode = "QR-55555555",
                Major = Major.DevOps,
                HashPassword = BCrypt.Net.BCrypt.HashPassword("12345678"),
                Role = UserRole.Client,
                Created = now
            },
            new User
            {
                Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                FirstName = "Ирек",
                LastName = "Шакиров",
                Email = "shakirov@gmail.com",
                QrCode = "QR-66666666",
                Major = Major.Frontend,
                HashPassword = BCrypt.Net.BCrypt.HashPassword("12345678"),
                Role = UserRole.Client,
                Created = now
            },
            new User
            {
                Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                FirstName = "Сергей",
                LastName = "Мещеряков",
                Email = "mescheryakov@gmail.com",
                QrCode = "QR-77777777",
                Major = Major.Mobile,
                HashPassword = BCrypt.Net.BCrypt.HashPassword("12345678"),
                Role = UserRole.Client,
                Created = now
            }
        );
    }
}