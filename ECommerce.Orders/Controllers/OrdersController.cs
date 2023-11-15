using AutoMapper;
using ECommerce.Orders.Interfaces;
using ECommerce.Orders.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Orders.Controllers
{
    public class OrdersController : Controller
    {
        IOrderService service;
        IMapper map;
        public OrdersController(IOrderService service, IMapper map)
        {
            this.service = service;
            this.map = map;
        }

        public async Task<IActionResult> GetAllOrders()
        {
            var result = await service.GetAllOrdersAsync();
            return Ok(result);
        }

        public async Task<IActionResult> GetOrderAsync(int CustomerID)
        {
            var result = await service.GetOrderAsync(CustomerID);
            return Ok(result);
        }
    }
}
