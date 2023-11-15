using ECommerce.Customers.DB;

namespace ECommerce.Customers.Interfaces
{
    public interface ICustomerRepo
    {
        Task<List<Customer>> GetAllCustomers();

        Task <Customer> GetCustomerById(int id);
    }
}
