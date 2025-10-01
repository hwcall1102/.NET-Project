using Microsoft.EntityFrameworkCore;
using TakeawayTitans.Data.Models;

namespace TakeawayTitans.Data
{
    public class TakeawayTitansContext : DbContext
    {
        public TakeawayTitansContext(DbContextOptions<TakeawayTitansContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed MenuItems: 5 Salads
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { Id = 1, Name = "Caesar Salad", Price = 7.25m, Description = "Crisp romaine with Caesar dressing.", ImageUrl = "https://example.com/caesar-salad.jpg" },
                new MenuItem { Id = 2, Name = "Greek Salad", Price = 7.50m, Description = "Tomatoes, cucumbers, feta, and olives.", ImageUrl = "https://example.com/greek-salad.jpg" },
                new MenuItem { Id = 3, Name = "Garden Salad", Price = 6.99m, Description = "Fresh mixed greens with seasonal veggies.", ImageUrl = "https://example.com/garden-salad.jpg" },
                new MenuItem { Id = 4, Name = "Spinach Salad", Price = 7.75m, Description = "Baby spinach, strawberries, and almonds.", ImageUrl = "https://example.com/spinach-salad.jpg" },
                new MenuItem { Id = 5, Name = "Cobb Salad", Price = 8.50m, Description = "Chicken, bacon, avocado, egg, and blue cheese.", ImageUrl = "https://example.com/cobb-salad.jpg" }
            );

            // Seed MenuItems: 5 Smoothies
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { Id = 6, Name = "Strawberry Smoothie", Price = 5.50m, Description = "Fresh strawberries blended with yogurt.", ImageUrl = "https://example.com/strawberry-smoothie.jpg" },
                new MenuItem { Id = 7, Name = "Mango Smoothie", Price = 5.75m, Description = "Ripe mangoes with orange juice.", ImageUrl = "https://example.com/mango-smoothie.jpg" },
                new MenuItem { Id = 8, Name = "Banana Smoothie", Price = 5.25m, Description = "Banana, milk, and honey.", ImageUrl = "https://example.com/banana-smoothie.jpg" },
                new MenuItem { Id = 9, Name = "Green Smoothie", Price = 6.00m, Description = "Spinach, kale, apple, and banana.", ImageUrl = "https://example.com/green-smoothie.jpg" },
                new MenuItem { Id = 10, Name = "Berry Blast Smoothie", Price = 6.25m, Description = "Mixed berries blended with yogurt.", ImageUrl = "https://example.com/berry-blast-smoothie.jpg" }
            );

            // Seed 5 users
            // Seed 5 users with fake names
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FName = "Alice", LName = "Johnson", Username = "admin1", Password = "password", Type = "admin" },
                new User { Id = 2, FName = "Bob", LName = "Smith", Username = "admin2", Password = "password", Type = "admin" },
                new User { Id = 3, FName = "Carol", LName = "Davis", Username = "admin3", Password = "password", Type = "admin" },
                new User { Id = 4, FName = "David", LName = "Martinez", Username = "admin4", Password = "password", Type = "admin" },
                new User { Id = 5, FName = "Emma", LName = "Wilson", Username = "admin5", Password = "password", Type = "admin" }
            );


            // Orders and OrderItems are intentionally left empty
        }
    }
}
