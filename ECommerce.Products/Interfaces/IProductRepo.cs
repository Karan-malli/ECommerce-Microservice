using ECommerce.Products.DB;

namespace ECommerce.Products.Interfaces
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task<Product> GetProduct(int id);
    }
}
