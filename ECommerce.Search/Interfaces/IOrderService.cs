using ECommerce.Search.Models;

namespace ECommerce.Search.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersAsync(int customerId);
    }

}
