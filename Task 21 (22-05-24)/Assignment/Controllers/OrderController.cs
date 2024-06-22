using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public OrderController(StoreContext dbContext)
        {
            _storeContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _storeContext.Orders.ToList();
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _storeContext.Orders.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteById(int id)
        {
            var user = _storeContext.Orders.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            _storeContext.Orders.Remove(user);
            _storeContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult add(Order order)
        {
            if (order == null)
            {
                return NotFound();
            }
            _storeContext.Orders.Add(order);
            _storeContext.SaveChanges();
            return Ok(order);
        }

        [HttpPut("{id}")]
        public IActionResult put(int id, Order order)
        {
            var ord = _storeContext.Orders.Find(id);
            if (ord == null)
            {
                return NotFound();
            }
            ord = order;
            _storeContext.SaveChanges();
            return Ok();
        }
    }
}
