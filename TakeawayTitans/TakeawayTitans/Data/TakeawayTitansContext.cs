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
}
