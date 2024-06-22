using assignmentWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreOrderController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public StoreOrderController(StoreContext dbContext)
        {
            _storeContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orders = _storeContext.StoreOrders;
            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var order = _storeContext.StoreOrders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpDelete]
        public IActionResult deleteById(int id)
        {
            var order = _storeContext.StoreOrders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            _storeContext.StoreOrders.Remove(order);
            _storeContext.SaveChanges();
            return Ok();
        }

        [HttpPost ("Add")]
        public IActionResult add(StoreOrder order)
        {
            if (order == null)
            {
                return NotFound();
            }
            _storeContext.StoreOrders.Add(order);
            _storeContext.SaveChanges();
            return Ok(order);
        }

        [HttpPut]
        public IActionResult put(int id, StoreOrder order)
        {
            var ord = _storeContext.StoreOrders.Find(id);
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