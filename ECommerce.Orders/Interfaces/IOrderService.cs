using ECommerce.Orders.Models;

namespace ECommerce.Orders.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllOrdersAsync();

        Task<List<Order>> GetOrderAsync(int CustomerID);
    }
}
