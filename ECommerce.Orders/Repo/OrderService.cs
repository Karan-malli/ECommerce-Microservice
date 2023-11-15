using AutoMapper;
using ECommerce.Orders.DB;
using ECommerce.Orders.Interfaces;
using ECommerce.Orders.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Orders.Repo
{
    public class OrderService : IOrderService
    {
        OrderDBContext dbContext;
        public OrderService(OrderDBContext dbcontext)
        {
            this.dbContext = dbcontext;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            var orders = await dbContext.Orders.ToListAsync();

            return orders;
        }

        public async Task<List<Order>> GetOrderAsync(int CustomerID)
        {
            var orders = await dbContext.Orders.Where(o => o.CustomerID == CustomerID)
                .Include(oi => oi.Items).ToListAsync();

            return orders;
        }
    }
}
