using Microsoft.EntityFrameworkCore;
using ECommerce.Products.Models;

namespace ECommerce.Products.DB
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ID = 1, Name = "Cello Bottle", Price = 50, Inventory = 5 },
                new Product { ID = 2, Name = "Dove Soap", Price = 13, Inventory = 8 },
                new Product { ID = 3, Name = "Photo Frame", Price = 8, Inventory = 12 },
                new Product { ID = 4, Name = "Vaseline", Price = 26, Inventory = 22 },
                new Product { ID = 5, Name = "Table Fan", Price = 59, Inventory = 10 });
        }

        public DbSet<ECommerce.Products.Models.Product> Product { get; set; } = default!;

    }
}
