using ECommerce.Orders.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Orders.DB
{
    public class OrderDBContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderDBContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    ID = 1,
                    CustomerID = 1,
                    OrderDate = DateTime.Now,
                    TotalPrice = 100
                },
                new Order()
                {
                    ID = 2,
                    CustomerID = 1,
                    OrderDate = DateTime.Now.AddDays(-1),
                    TotalPrice = 100
                },
                new Order()
                {
                    ID = 3,
                    CustomerID = 2,
                    OrderDate = DateTime.Now,
                    TotalPrice = 100
                });

            modelBuilder.Entity<OrderItem>().HasData(
                        new OrderItem() { ID = 1, OrderID = 1, ProductID = 1, Quantity = 10, Price = 10 },
                        new OrderItem() { ID = 2, OrderID = 1, ProductID = 2, Quantity = 20, Price = 20 },
                        new OrderItem() { ID = 3, OrderID = 1, ProductID = 3, Quantity = 30, Price = 30 },
                        new OrderItem() { ID = 4, OrderID = 2, ProductID = 2, Quantity = 2, Price = 210 },
                        new OrderItem() { ID = 5, OrderID = 3, ProductID = 3, Quantity = 3, Price = 310 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
