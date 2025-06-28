// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using InvMgt.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Apple iPhone 15", Price = 1200.00m },
            new Product { Id = 2, Name = "Samsung Galaxy S24", Price = 1100.00m },
            new Product { Id = 3, Name = "Google Pixel 8", Price = 999.99m },
            new Product { Id = 4, Name = "OnePlus 12", Price = 950.00m },
            new Product { Id = 5, Name = "Xiaomi 14 Pro", Price = 875.00m }
        );
    }
}
