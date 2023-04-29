using Dapper;
using DapperSample_API.Models;

namespace DapperSample_API.DataRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _context;

        public CustomerRepository(DapperContext dapperContext)
        {
            _context = dapperContext;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            var query = "SELECT * FROM sales.customers";

            using( var connection = _context.CreateConnection() )
            {
                var customers = await connection.QueryAsync<Customer>(query);
                return customers.ToList();
            }
        }

        public async Task<Customer> GetById(int id)
        {
            var query = "SELECT * FROM sales.customers WHERE Id = @id";

            using (var connection = _context.CreateConnection())
            {
                var customer = await connection.QuerySingleOrDefaultAsync<Customer>(query, new { id});
                return customer;
            }
        }
    }
}
