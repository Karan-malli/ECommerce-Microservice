using ECommerce.Search.Interfaces;
using ECommerce.Search.Models;
using System.Text.Json;

namespace ECommerce.Search.Repo
{
    public class ProductService : IProductRepo
    {

        IHttpClientFactory factory;
        public ProductService(IHttpClientFactory factory)
        {
            this.factory = factory;
        }


        public Task<List<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProduct(int id)
        {
            var httpFactory = factory.CreateClient("ProductService");
            var response = httpFactory.GetAsync($"Product/GetProduct?ID={id}");
            var content = await response.Result.Content.ReadAsByteArrayAsync();
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var result = JsonSerializer.Deserialize<Product>(content, options);
            return result;

        }
    }
}
