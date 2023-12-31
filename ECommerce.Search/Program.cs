using ECommerce.Search.Interfaces;
using ECommerce.Search.Repo;

namespace ECommerce.Search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddHttpClient("OrderService", Config =>
            {
                Config.BaseAddress = new Uri(builder.Configuration["Services:Orders"]);
            });
            builder.Services.AddHttpClient("ProductService", config =>
            {
                config.BaseAddress = new Uri(builder.Configuration["Services:Products"]);
            });


            builder.Services.AddScoped<ISearchService, SearchService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IProductRepo, ProductService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
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