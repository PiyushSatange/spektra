using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Models;

namespace StoreManagement.Controllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        [HttpGet]
        public ActionResult GetAll()
        {
            var orders = _storeContext.Orders;
            if(orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        [HttpGet]
        public ActionResult GetById(int id) 
        {
            var order = _storeContext.Orders.Find(id);
            if(order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpDelete]
        public ActionResult deleteById(int id)
        {
            var order = _storeContext.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            _storeContext.Orders.Remove(order);
            _storeContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public ActionResult add(Order order)
        {
            if (order == null)
            {
                return NotFound();
            }
            _storeContext.Orders.Add(order);
            _storeContext.SaveChanges();
            return Ok(order);
        }

        [HttpPut]
        public ActionResult put(int id, Order order)
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
