using Microsoft.EntityFrameworkCore;
using UsersService.Domain.Entities;
using UsersService.Domain.Enums;

namespace UsersService.Infrastructure.Repositories;

public class EventDbContext(DbContextOptions<EventDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<Festival> Festivals { get; set; } = null!;
    public DbSet<Floor> Floors { get; set; } = null!;
    public DbSet<Zone> Zones { get; set; } = null!;
    public DbSet<Speaker> Speakers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Festival configuration
        modelBuilder.Entity<Festival>()
            .HasKey(f => f.Id);
        
        modelBuilder.Entity<Festival>()
            .HasMany(f => f.Events)
            .WithOne(e => e.Festival)
            .HasForeignKey(e => e.FestivalId)
            .OnDelete(DeleteBehavior.Cascade);

        // Floor configuration
        modelBuilder.Entity<Floor>()
            .HasKey(f => f.Id);
        
        modelBuilder.Entity<Floor>()
            .HasMany(f => f.Zones)
            .WithOne(z => z.Floor)
            .HasForeignKey(z => z.FloorId)
            .OnDelete(DeleteBehavior.Cascade);

        // Zone configuration
        modelBuilder.Entity<Zone>()
            .HasKey(z => z.Id);
        
        modelBuilder.Entity<Zone>()
            .HasMany(z => z.Events)
            .WithOne(e => e.Zone)
            .HasForeignKey(e => e.ZoneId)
            .OnDelete(DeleteBehavior.Cascade);

        // Speaker configuration
        modelBuilder.Entity<Speaker>()
            .HasKey(s => s.Id);
        
        modelBuilder.Entity<Speaker>()
            .HasMany(s => s.Events)
            .WithOne(e => e.Speaker)
            .OnDelete(DeleteBehavior.SetNull);

        // Event configuration
        modelBuilder.Entity<Event>()
            .HasKey(e => e.Id);
        
        modelBuilder.Entity<Event>()
            .Property(e => e.EventType)
            .HasConversion<string>();
    }
}

