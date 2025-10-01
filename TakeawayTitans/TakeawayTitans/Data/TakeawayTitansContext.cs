using Microsoft.EntityFrameworkCore;
using TakeawayTitans.Models;
using RestaurantApi.Models;

namespace TakeawayTitans.Data;

public class TakeawayTitansContext : DbContext
{
    public TakeawayTitansContext(DbContextOptions<TakeawayTitansContext> options)
        : base(options)
    {
    }

    public DbSet<MenuItem> MenuItem { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var hashedPW = BCrypt.Net.BCrypt.HashPassword("123456");
        var admin = new User()
        {
            Id = Guid.NewGuid(),
            Email = "test@gmail.com",
            PasswordHash = hashedPW,
            FirstName = "Test",
            LastName = "User",
            Role = UserRole.Admin,
            ImageUrl = "https://picsum.photos/id/64/200",
            CreatedAt = DateTime.UtcNow,
        };
        modelBuilder.Entity<User>().HasData(admin);
    }
}
