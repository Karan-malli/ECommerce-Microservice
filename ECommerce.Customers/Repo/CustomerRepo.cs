
using ECommerce.Customers.DB;
using ECommerce.Customers.Interfaces;

namespace ECommerce.Customers.Repo
{
    public class CustomerRepo : ICustomerRepo
    {
        public Task<List<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
