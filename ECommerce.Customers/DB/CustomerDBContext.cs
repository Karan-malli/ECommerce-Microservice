using Microsoft.EntityFrameworkCore;

namespace ECommerce.Customers.DB
{
    public class CustomerDBContext:DbContext
    {
        public CustomerDBContext(DbContextOptions options):base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { CustomerID = 1,Name="Thor",Email="karan@ep.com",Phone=911911911 },
                new Customer() { CustomerID = 2, Name = "Loki", Email = "Loki@ep.com", Phone = 420420420 },
                new Customer() { CustomerID = 3, Name = "Thanos", Email = "Thanos@ep.com", Phone = 786786786 },
                new Customer() { CustomerID = 4, Name = "Steve", Email = "Steve@ep.com", Phone = 007007007 }
                );
        }
    }
}
