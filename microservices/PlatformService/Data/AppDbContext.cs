using Microsoft.EntityFrameworkCore;
using PlatformService.Model;

namespace PlatformService.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public required DbSet<Platform> Platforms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedInitialData();

        base.OnModelCreating(modelBuilder);
    }
}