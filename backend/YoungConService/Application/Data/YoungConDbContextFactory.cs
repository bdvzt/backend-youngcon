using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using YoungConService.Infrastructure.Repositories;

namespace YoungConService.Application.Data;

public class YoungConDbContextFactory : IDesignTimeDbContextFactory<YoungConDbContext>
{
    public YoungConDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<YoungConDbContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=55433;Database=usersdb;Username=postgres;Password=postgres");
        return new YoungConDbContext(optionsBuilder.Options);
    }
}

