using DapperSample_API.Models;

namespace DapperSample_API.DataRepository
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<Customer>> GetAll();
        public Task<Customer> GetById(int id);
    }
}
