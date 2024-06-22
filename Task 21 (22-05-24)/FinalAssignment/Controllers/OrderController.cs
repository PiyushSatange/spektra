using FinalAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FinalAssignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly Store1Context _store1Context;

        public OrderController(Store1Context dbContext)
        {
            _store1Context = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllOrderDetails()
        {
            var orders = _store1Context.OrderDetails.FromSqlRaw("exec getAllOrderDetails").ToList();
            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderDetails(int id) 
        {
            var order = _store1Context.OrderDetails.FromSqlRaw("EXEC getOrderDetails @id", new SqlParameter("@id", id));
            if(order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orders = _store1Context.Orders;
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _store1Context.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost]
        public IActionResult post(Order order)
        {
            if (order == null)
            {
                return NotFound();
            }
            _store1Context.Orders.Add(order);
            _store1Context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult put(int id, Order order)
        {
            if (order == null)
            {
                return NotFound();
            }
            var ordr = _store1Context.Orders.Find(id);
            if (ordr == null)
            {
                return NotFound();
            }
            ordr.TotalAmount = order.TotalAmount;
            ordr.ProductId = order.ProductId;
            ordr.CustomerId = order.CustomerId;

            _store1Context.Orders.Update(ordr);
            _store1Context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _store1Context.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            _store1Context.Orders.Remove(order);
            _store1Context.SaveChanges();
            return Ok();
        }
    }
}
