using ECommerce.Customers.DB;
using ECommerce.Customers.Interfaces;
using ECommerce.Customers.Repo;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Customers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();

            builder.Services.AddDbContext<CustomerDBContext>(option =>
            {
                option.UseSqlServer(
                    builder.Configuration.GetConnectionString("CustomerConnection"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Customer/GetAllCustomers");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}