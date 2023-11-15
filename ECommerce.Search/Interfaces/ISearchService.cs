using ECommerce.Search.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Search.Interfaces
{
    public interface ISearchService
    {
        Task<List<Order>> SearchAsync(int ID);
    }
}
