using ECommerce.Search.Interfaces;
using ECommerce.Search.Models;
using System.Text.Json;

namespace ECommerce.Search.Repo
{
    public class OrderService : IOrderService
    {

        public IHttpClientFactory httpClientFactory;


        public OrderService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<List<Order>> GetOrdersAsync(int customerId)
        {
            var client = httpClientFactory.CreateClient("OrderService");
            var response = client.GetAsync($"Orders/GetOrder?CustomerID={customerId}");
            var content = await response.Result.Content.ReadAsByteArrayAsync();
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var result = JsonSerializer.Deserialize<List<Order>>(content, options);
            return result;

        }
    }
}
