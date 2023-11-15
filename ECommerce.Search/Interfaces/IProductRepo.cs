using ECommerce.Search.Models;

namespace ECommerce.Search.Interfaces
{
    public interface IProductRepo
    {
        Task<List<Product>> GetAllProducts();

        Task<Product> GetProduct(int id);
    }
}
