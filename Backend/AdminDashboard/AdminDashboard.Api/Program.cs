using AdminDashboard.Api.Data;
using AdminDashboard.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

#region Data Seed

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (!db.Users.Any())
    {
        db.Users.AddRange(
            new User { Email = "admin@test.com", Role = Role.admin, Password = "admin" },
            new User { Email = "user@test.com", Role = Role.user, Password = "user" }
        );
    }

    if (!db.Products.Any())
    {
        db.Products.AddRange(
            new Product { Name = "Keyboard", Price = 25.99m, Stock = 10 },
            new Product { Name = "Mouse", Price = 15.50m, Stock = 20 }
        );
    }

    db.SaveChanges();
}

#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
