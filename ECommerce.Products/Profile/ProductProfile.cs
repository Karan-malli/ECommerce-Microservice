using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerce.Products.Profile
{
    public class ProductProfile:AutoMapper.Profile
    {
        public ProductProfile() {
            CreateMap<DB.Product, Models.Product>();
        } 
    }
}
