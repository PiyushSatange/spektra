using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MobileShoopy.Models;

namespace MobileShoopy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OnlineMobileSiteContext _MobileContext;

        public OrderController(OnlineMobileSiteContext DbContext)
        {
            _MobileContext = DbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Orders = _MobileContext.Orders;
            if (Orders == null)
            {
                return NotFound("the list is empty");
            }
            return Ok(Orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Order = _MobileContext.Orders.Find(id);
            if (Order == null)
            {
                return NotFound("The id is not present");
            }
            return Ok(Order);
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            if (order == null)
            {
                return NotFound("Null order can not be inserted");
            }
            _MobileContext.Orders.Add(order);
            _MobileContext.SaveChanges();
            return Ok(order);
        }

        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            var Order = _MobileContext.Orders.Find(id);
            if (Order == null)
            {
                return NotFound("The id is not present");
            }
            _MobileContext.Orders.Remove(Order);
            _MobileContext.SaveChanges();
            return Ok(Order);
        }

        [HttpPut]
        public IActionResult UpdateOrder(int id, Order order)
        {
            if (order == null)
            {
                return BadRequest("Null Object Exception");
            }
            if (id != order.Oid)
            {
                return BadRequest("Id is not matching");
            }
            var ordr = _MobileContext.Orders.Find(id);
            if (ordr == null)
            {
                return NotFound("order not present with this id");
            }
            ordr.Mid = order.Mid;
            ordr.Cid = order.Cid;
            _MobileContext.Orders.Update(ordr);
            _MobileContext.SaveChanges();
            return Ok(ordr);
        }

        [HttpGet("Procedure")]
        public IActionResult GetProcedure()
        {
            var result = _MobileContext.Procedures.FromSqlRaw("Exec ShowOrderDetails").ToList();
            if (result == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpGet("ProcedureById/{id}")]
        public IActionResult GetProcedureById(int id)
        {
            var param = new SqlParameter("@id", id);
            var result = _MobileContext.Procedures.FromSqlRaw("Exec ShowOrderDetailsById @id", param);
            if (result == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
