using ECommerce.Products.DB;
using ECommerce.Products.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Products.Providers
{
    public class ProductRepo : IProductRepo
    {
        ProductDbContext db;
        public ProductRepo(ProductDbContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await db.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var result = await db.Products.FirstOrDefaultAsync(pro=>pro.ID==id);
            return result;
        }
    }
}
