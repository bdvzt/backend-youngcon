using Microsoft.EntityFrameworkCore;
using UsersService.Domain.Entities;
using UsersService.Domain.Enums;

namespace UsersService.Infrastructure.Repositories;

public class EventDbContext(DbContextOptions<EventDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(x => x.Email)
            .IsUnique();

        var now = DateTime.UtcNow;

        modelBuilder.Entity<User>().HasData(
            //Сотрудники
            new User
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                FirstName = "Леша",
                LastName = "Агеев",
                Email = "ageev@gmail.com",
                HashPassword = BCrypt.Net.BCrypt.HashPassword("12345678"),
                Role = UserRole.Employee,
                Created = now
            },

            //Клиенты
            new User
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                FirstName = "Заята",
                LastName = "Будаева",
                Email = "budaeva@gmail.com",
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
                HashPassword = BCrypt.Net.BCrypt.HashPassword("12345678"),
                Role = UserRole.Client,
                Created = now
            }
        );
    }
}