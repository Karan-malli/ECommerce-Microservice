using ECommerce.Search.Interfaces;
using ECommerce.Search.Models;

namespace ECommerce.Search.Repo
{
    public class SearchService : ISearchService
    {
        IOrderService order;
        public SearchService(IOrderService order)
        {
            this.order = order;
        }

        public async Task<List<Order>> SearchAsync(int ID)
        {
            List<Order> Orders = await order.GetOrdersAsync(ID);
            return Orders;
        }
    }
}
