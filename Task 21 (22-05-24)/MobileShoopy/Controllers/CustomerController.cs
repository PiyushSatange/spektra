using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MobileShoopy.Models;

namespace MobileShoopy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly OnlineMobileSiteContext _MobileContext;

        public CustomerController(OnlineMobileSiteContext dbContext)
        {
            _MobileContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Customers = _MobileContext.Customers;
            if (Customers == null)
            {
                return BadRequest("Customers is null");
            }
            return Ok(Customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Customer = _MobileContext.Customers.Find(id);
            if (Customer == null)
            {
                return NotFound("id with this value is not present");
            }
            return Ok(Customer);
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("null values can not be injected");
            }
            _MobileContext.Customers.Add(customer);
            _MobileContext.SaveChanges();
            return Ok(customer);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, Customer Customer)
        {
            if (Customer.Cid != id)
            {
                return BadRequest("Id's are not matching");
            }
            if (Customer == null)
            {
                return BadRequest("Customer is null here");
            }
            var ExistingCustomer = _MobileContext.Customers.Find(id);
            if (ExistingCustomer == null)
            {
                return NotFound("The customer is not available with this id");
            }
            ExistingCustomer.Cnumber = Customer.Cnumber;
            ExistingCustomer.Cemail = Customer.Cemail;
            ExistingCustomer.Caddress = Customer.Caddress;
            ExistingCustomer.Cname = Customer.Cname;
            _MobileContext.Customers.Update(ExistingCustomer);
            _MobileContext.SaveChanges();
            return Ok(ExistingCustomer);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var Customer = _MobileContext.Customers.Find(id);
            if (Customer == null)
            {
                return BadRequest("id is not present");
            }
            _MobileContext.Customers.Remove(Customer);
            _MobileContext.SaveChanges();
            return Ok(Customer);
        }

        [HttpGet("GetCustomerbyProductId/{productId}")]
        public IActionResult GetCustomerbyProductId(int productId)
        {
            var param = new SqlParameter("@id", productId);
            var result = _MobileContext.Customers.FromSqlRaw("exec getCustomerByProduct @id", param).ToList();
            return Ok(result);
        }
    }
}
