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
                new MenuItem { Id = 1, Name = "Caesar Salad", Price = 7.25m, Description = "Crisp romaine with Caesar dressing.", ImageUrl = "https://images.pexels.com/photos/8251537/pexels-photo-8251537.jpeg" },
                new MenuItem { Id = 2, Name = "Greek Salad", Price = 7.50m, Description = "Tomatoes, cucumbers, feta, and olives.", ImageUrl = "https://www.cookipedia.co.uk/wiki/images/8/87/Greek_salad_recipe.jpg" },
                new MenuItem { Id = 3, Name = "Garden Salad", Price = 6.99m, Description = "Fresh mixed greens with seasonal veggies.", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmzYDNf1qIDSjvZLHCi98piiao6gi6K7ZIyw&s" },
                new MenuItem { Id = 4, Name = "Spinach Salad", Price = 7.75m, Description = "Baby spinach, strawberries, and almonds.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c4/Salad_with_strawberries.jpg" },
                new MenuItem { Id = 5, Name = "Cobb Salad", Price = 8.50m, Description = "Chicken, bacon, avocado, egg, and blue cheese.", ImageUrl = "https://images.stockcake.com/public/6/f/6/6f6293cf-b710-40e3-b0c6-af329f49c182/hearty-cobb-salad-stockcake.jpg" }
            );

            // Seed MenuItems: 5 Smoothies
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { Id = 6, Name = "Strawberry Smoothie", Price = 5.50m, Description = "Fresh strawberries blended with yogurt.", ImageUrl = "https://images.pexels.com/photos/8169597/pexels-photo-8169597.jpeg" },
                new MenuItem { Id = 7, Name = "Mango Smoothie", Price = 5.75m, Description = "Ripe mangoes with orange juice.", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEg03LIorRnJYimTc6rQ0rLUd_B9RrKp0GnA&s" },
                new MenuItem { Id = 8, Name = "Banana Smoothie", Price = 5.25m, Description = "Banana, milk, and honey.", ImageUrl = "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvaXMxMTA0NS1pbWFnZS1rd3lzaTYwZC5qcGc.jpg" },
                new MenuItem { Id = 9, Name = "Green Smoothie", Price = 6.00m, Description = "Spinach, kale, apple, and banana.", ImageUrl = "https://i1.pickpik.com/photos/153/22/476/green-smoothie-drink-healthy-preview.jpg" },
                new MenuItem { Id = 10, Name = "Berry Blast Smoothie", Price = 6.25m, Description = "Mixed berries blended with yogurt.", ImageUrl = "https://i1.pickpik.com/photos/585/986/375/smoothie-milkshake-mixed-berry-preview.jpg" }
            );

            // Seed Users
            var hashedPW = BCrypt.Net.BCrypt.HashPassword("123456");

            modelBuilder.Entity<User>().HasData(
                // 3 Admins
                new User
                {
                    Id = 1,
                    Email = "test@gmail.com",
                    PasswordHash = hashedPW,
                    FirstName = "Test",
                    LastName = "User",
                    Role = UserRole.Admin,
                    ImageUrl = "https://picsum.photos/id/64/200",
                    CreatedAt = DateTime.UtcNow,
                },
                new User
                {
                    Id = 2,
                    Email = "alice.johnson@example.com",
                    PasswordHash = hashedPW,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Role = UserRole.Admin,
                    ImageUrl = "https://picsum.photos/id/101/200",
                    CreatedAt = DateTime.UtcNow,
                },
                new User
                {
                    Id = 3,
                    Email = "bob.smith@example.com",
                    PasswordHash = hashedPW,
                    FirstName = "Bob",
                    LastName = "Smith",
                    Role = UserRole.Admin,
                    ImageUrl = "https://picsum.photos/id/102/200",
                    CreatedAt = DateTime.UtcNow,
                },

                // 2 Regular Users
                new User
                {
                    Id = 4,
                    Email = "carol.davis@example.com",
                    PasswordHash = hashedPW,
                    FirstName = "Carol",
                    LastName = "Davis",
                    Role = UserRole.User,
                    ImageUrl = "https://picsum.photos/id/103/200",
                    CreatedAt = DateTime.UtcNow,
                },
                new User
                {
                    Id = 5,
                    Email = "david.martinez@example.com",
                    PasswordHash = hashedPW,
                    FirstName = "David",
                    LastName = "Martinez",
                    Role = UserRole.User,
                    ImageUrl = "https://picsum.photos/id/104/200",
                    CreatedAt = DateTime.UtcNow,
                }
            );

            // Orders and OrderItems are intentionally left empty
        }
    }
}
