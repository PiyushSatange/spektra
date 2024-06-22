using FinalAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly Store1Context _store1Context;

        public CustomerController(Store1Context dbContext)
        {
            _store1Context = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Customers = _store1Context.Customers;
            return Ok(Customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _store1Context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult post(Customer customer)
        {
            if (customer == null)
            {
                return NotFound();
            }
            _store1Context.Customers.Add(customer);
            _store1Context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult put(int id,  Customer customer)
        {
            if(customer == null)
            {
                return NotFound();
            }
            var cstmr = _store1Context.Customers.Find(id);
            if(cstmr == null)
            {
                return NotFound();
            }
            cstmr.Name = customer.Name;
            cstmr.Email = customer.Email;
            cstmr.Number = customer.Number;

            _store1Context.Customers.Update(cstmr);
            _store1Context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _store1Context.Customers.Find(id);
            if(customer == null)
            {
                return NotFound();
            }
            _store1Context.Customers.Remove(customer);
            _store1Context.SaveChanges();
            return Ok();
        }
    }
}
