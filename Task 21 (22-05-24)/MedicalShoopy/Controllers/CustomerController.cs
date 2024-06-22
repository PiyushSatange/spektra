using MedicalShoopy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MedicalShoopy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly MedicalShopContext _context;

        public CustomerController(MedicalShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Customers = _context.Customers;
            if (Customers == null)
            {
                return NotFound("the list is null");
            }
            return Ok(Customers);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Customer = _context.Customers.Find(id);
            if (Customer == null)
            {
                return NotFound("the customer with this id is not available");
            }
            return Ok(Customer);
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("The customer is null here");
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok(customer);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest("The id is not matching");
            }
            if (customer == null)
            {
                return BadRequest("Null customer can not be inserted");
            }
            var ExistingCustomer = _context.Customers.Find(id);
            if (ExistingCustomer == null)
            {
                return NotFound("The id is not present to update");
            }
            ExistingCustomer.Email = customer.Email;
            ExistingCustomer.Location = customer.Location;
            ExistingCustomer.Name = customer.Name;
            ExistingCustomer.PhoneNo = customer.PhoneNo;
            _context.Customers.Update(ExistingCustomer);
            _context.SaveChanges();
            return Ok(ExistingCustomer);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Customer = _context.Customers.Find(id);
            if (Customer == null)
            {
                return NotFound("Customer with this id is not available");
            }
            _context.Customers.Remove(Customer);
            _context.SaveChanges();
            return Ok(Customer);
        }

        [HttpGet("GetCustomerbyProductId/{productId}")]
        public IActionResult GetCustomerbyProductId(int productId)
        {
            var param = new SqlParameter("@id", productId);
            var result = _context.Customers.FromSqlRaw("exec getCustomerByProduct @id", param).ToList();
            return Ok(result);
        }

    }
}
