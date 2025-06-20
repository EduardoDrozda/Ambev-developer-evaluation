using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Seeders;

/// <summary>
/// Seeds the development database with default users, branches, and products.
/// </summary>
public class DatabaseSeeder(IPasswordHasher passwordHasher)
{
    public async Task SeedAsync(DefaultContext context)
    {
        await SeedUsersAsync(context);
        await SeedBranchesAsync(context);
        await SeedProductsAsync(context);
        await context.SaveChangesAsync();
    }

    private async Task SeedUsersAsync(DefaultContext context)
    {
        if (!await context.Users.AnyAsync())
        {
            var admin = new User
            {
                Id = Guid.NewGuid(),
                Username = "Admin User",
                Email = "admin@email.com",
                Phone = "(11) 99999-9999",
                Role = UserRole.Admin,
                Status = UserStatus.Active,
                Password = passwordHasher.HashPassword("Admin1219@@!"),
                CreatedAt = DateTime.UtcNow
            };

            var customer1 = new User
            {
                Id = Guid.NewGuid(),
                Username = "Customer User 1",
                Email = "customer1@devstore.com",
                Phone = "11988888888",
                Role = UserRole.Customer,
                Status = UserStatus.Active,
                Password = passwordHasher.HashPassword("Customer1219@@!"),
                CreatedAt = DateTime.UtcNow
            };

            var customer2 = new User
            {
                Id = Guid.NewGuid(),
                Username = "Customer User 2",
                Email = "customer2@devstore.com",
                Phone = "11987777777",
                Role = UserRole.Customer,
                Status = UserStatus.Active,
                Password = passwordHasher.HashPassword("Customer1219@@!"),
                CreatedAt = DateTime.UtcNow
            };

            await context.Users.AddRangeAsync(admin, customer1, customer2);
        }
    }

    private async Task SeedBranchesAsync(DefaultContext context)
    {
        if (!await context.Branches.AnyAsync())
        {
            var branches = new[]
            {
                new Branch
                {
                    Id = Guid.NewGuid(),
                    Name = "Downtown Branch",
                    Address = "123 Main St",
                    CreatedAt = DateTime.UtcNow
                },
                new Branch
                {
                    Id = Guid.NewGuid(),
                    Name = "North Branch",
                    Address = "456 North Ave",
                    CreatedAt = DateTime.UtcNow
                },
                new Branch
                {
                    Id = Guid.NewGuid(),
                    Name = "South Branch",
                    Address = "789 South Blvd",
                    CreatedAt = DateTime.UtcNow
                }
            };

            await context.Branches.AddRangeAsync(branches);
        }
    }

    private async Task SeedProductsAsync(DefaultContext context)
    {
        if (!await context.Products.AnyAsync())
        {
            var products = new[]
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Skol Pilsen 350ml",
                    Description = "Skol Pilsen can beer - 350ml",
                    UnitPrice = 3.50m,
                    CreatedAt = DateTime.UtcNow
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Brahma Duplo Malte 350ml",
                    Description = "Brahma Duplo Malte can beer - 350ml",
                    UnitPrice = 4.00m,
                    CreatedAt = DateTime.UtcNow
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Guaraná Antarctica 2L",
                    Description = "Guaraná Antarctica soft drink - 2 liters",
                    UnitPrice = 6.00m,
                    CreatedAt = DateTime.UtcNow
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Pepsi 350ml",
                    Description = "Pepsi can soft drink - 350ml",
                    UnitPrice = 3.00m,
                    CreatedAt = DateTime.UtcNow
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "H2OH! Limão 500ml",
                    Description = "H2OH! lemon flavored water - 500ml",
                    UnitPrice = 4.50m,
                    CreatedAt = DateTime.UtcNow
                }
            };

            await context.Products.AddRangeAsync(products);
        }
    }
}
