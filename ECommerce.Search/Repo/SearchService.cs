using ECommerce.Search.Interfaces;
using ECommerce.Search.Models;

namespace ECommerce.Search.Repo
{
    public class SearchService : ISearchService
    {
        IOrderService order;
        IProductRepo product;
        public SearchService(IOrderService order, IProductRepo product)
        {
            this.order = order;
            this.product = product;
        }

        public async Task<List<Order>> SearchAsync(int ID)
        {
            List<Order> Orders = await order.GetOrdersAsync(ID);
            return Orders;
        }

        public async Task<Product> SearchProductAsync(int ID)
        {
            Product prod = await product.GetProduct(ID);
            return prod;

        }
    }
}
