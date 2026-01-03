using AdminDashboard.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminDashboard.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Product> Products => Set<Product>();
    }
}
