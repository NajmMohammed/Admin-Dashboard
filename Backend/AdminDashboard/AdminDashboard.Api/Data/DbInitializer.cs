using AdminDashboard.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AdminDashboard.Api.Data
{
    public static class DbInitializer
    {
        public static async Task SeedAdminAsync (AppDbContext context)
        {
            if (await context.Users.AnyAsync(u => u.Role == "admin"))
                return;
            var passwordHasher = new PasswordHasher<User>();
            var admin = new User
            {
                Name = "Admin",
                Email = "admin@dashboard.com",
                Role = "admin"
            };
            admin.Password = passwordHasher.HashPassword(admin, "Admin123");
            context.Users.Add(admin);
            await context.SaveChangesAsync();
        }
    }
}
