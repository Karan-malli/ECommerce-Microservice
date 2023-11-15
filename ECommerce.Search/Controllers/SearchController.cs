using ECommerce.Search.Interfaces;
using ECommerce.Search.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Search.Controllers
{
    public class SearchController : Controller
    {
        ISearchService repo;
        public SearchController(ISearchService repo)
        {
            this.repo = repo;
        }

        public async Task<ActionResult> SearchAsync(int CustomerID)
        {
            var result = await repo.SearchAsync(CustomerID);
            return Ok(result);
        }


        public async Task<ActionResult> SearchProductAsync(int ID)
        {
            var result = await repo.SearchProductAsync(ID);
            return Ok(result);
        }

    }
}
