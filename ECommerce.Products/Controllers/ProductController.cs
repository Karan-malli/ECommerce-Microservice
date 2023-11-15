using AutoMapper;
using ECommerce.Products.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Products.Controllers
{
    public class ProductController : Controller
    {
        IProductRepo repo;
        IMapper map;
        public ProductController(IProductRepo repo, IMapper map)
        {
            this.repo = repo;
            this.map = map; 
        }

        public async Task<IActionResult> GetAllProductsAsync()
        {
            var result = await repo.GetAllProducts();
            return View(result);
        }

        public async Task<IActionResult> GetProductAsync(int id)
        {
            var pro = await repo.GetProduct(id);
            var result= map.Map<DB.Product,Models.Product>(pro);
            return Ok(result);
        }
    }
}
