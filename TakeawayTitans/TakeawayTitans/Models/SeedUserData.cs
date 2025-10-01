using System;
using TakeawayTitans.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace TakeawayTitans.Models;

public class SeedUserData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<TakeawayTitansContext>();

        context.Database.Migrate();

        if (context.Users.Any()) return;

        var hashedPW = BCrypt.Net.BCrypt.HashPassword("123456");
        var user = new User()
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

        context.Users.Add(user);
        context.SaveChanges();
        
    }
}
