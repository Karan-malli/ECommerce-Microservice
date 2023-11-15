using ECommerce.Search.Interfaces;
using ECommerce.Search.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Search.Providers
{
    public class SearchRepo:ISearchService
    {
        public SearchRepo() { }

        public async Task<bool> SearchAsync(int ID)
        {
            await Task.Delay(1);
            return true;
        }
    }
}
