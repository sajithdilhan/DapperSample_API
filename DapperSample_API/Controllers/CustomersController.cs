using DapperSample_API.DataRepository;
using DapperSample_API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperSample_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
           _customerRepository = customerRepository;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            var customers = await _customerRepository.GetAll();
            return customers;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<Customer> Get(int id)
        {
            var customer = await _customerRepository.GetById(id);
            return customer;
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
