using MedicalShoopy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MedicalShoopy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly MedicalShopContext _context;

        public OrderController(MedicalShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Orders = _context.Orders;
            if (Orders == null)
            {
                return NotFound("the list is null");
            }
            return Ok(Orders);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Order = _context.Orders.Find(id);
            if (Order == null)
            {
                return NotFound("the order with this id is not available");
            }
            return Ok(Order);
        }

        [HttpPost]
        public IActionResult Post(Order order)
        {
            if (order == null)
            {
                return BadRequest("The order is null here");
            }
            _context.Orders.Add(order);
            _context.SaveChanges();
            return Ok(order);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest("The id is not matching");
            }
            if (order == null)
            {
                return BadRequest("Null order can not be inserted");
            }
            var ExistingOrder = _context.Orders.Find(id);
            if (ExistingOrder == null)
            {
                return NotFound("The id is not present to update");
            }
            ExistingOrder.ProductId = order.ProductId;
            ExistingOrder.CustomerId = order.CustomerId;
            _context.SaveChanges();
            return Ok(ExistingOrder);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Order = _context.Orders.Find(id);
            if (Order == null)
            {
                return NotFound("Order with this id is not available");
            }
            _context.Orders.Remove(Order);
            _context.SaveChanges();
            return Ok(Order);
        }

        [HttpGet("Procedure")]
        public IActionResult GetProcedure()
        {
            var result = _context.Procedures.FromSqlRaw("Exec ShowOrderDetails").ToList();
            if(result == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpGet("ProcedureById/{id}")]
        public IActionResult GetProcedureById(int id)
        {
            var param = new SqlParameter("@id", id);
            var result = _context.Procedures.FromSqlRaw("Exec ShowOrderDetailsById @id", param);
            if(result == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
