using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MobileShoopy.Models;

namespace MobileShoopy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly OnlineMobileSiteContext _MobileContext;

        public MobileController(OnlineMobileSiteContext DbContext)
        {
            _MobileContext = DbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var MobileList = _MobileContext.Mobiles.ToList();
            return Ok(MobileList);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var mobile = _MobileContext.Mobiles.Find(id);
            if (mobile == null)
            {
                return BadRequest("Mobile with this id is not present");
            }
            return Ok(mobile);
        }

        [HttpPost]
        public IActionResult AddMobile(Mobile mobile)
        {
            if (mobile == null)
            {
                return BadRequest("Null entity can not be added");
            }
            _MobileContext.Mobiles.Add(mobile);
            _MobileContext.SaveChanges();
            return Ok(mobile);
        }

        [HttpDelete]
        public IActionResult RemoveMobile(int id)
        {
            var mobile = _MobileContext.Mobiles.Find(id);
            if (mobile == null)
            {
                return BadRequest("Mobile with this id does not exist");
            }
            _MobileContext.Mobiles.Remove(mobile);
            _MobileContext.SaveChanges();
            return Ok(mobile);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMobile(int id, Mobile mobile)
        {
            var ExistingMobile = _MobileContext.Mobiles.Find(id);
            if (ExistingMobile == null)
            {
                return BadRequest("Mobile with this id does not exist");
            }
            ExistingMobile.Mtitle = mobile.Mtitle;
            ExistingMobile.Mdetails = mobile.Mdetails;
            ExistingMobile.Mrating = mobile.Mrating;
            ExistingMobile.Msrc = mobile.Msrc;
            ExistingMobile.Price = mobile.Price;
            _MobileContext.Mobiles.Update(ExistingMobile);
            _MobileContext.SaveChanges();
            return Ok(ExistingMobile);
        }

        [HttpPut("reduceQuantity/{id}")]
        public IActionResult ReduceQuantity(int id, int quantity)
        {
            var product = _MobileContext.Mobiles.Find(id);
            if (product == null)
            {
                return NotFound("Product with this id is not available");
            }
            if (product.quantity < quantity)
            {
                return BadRequest("The quantity is not available");
            }
            product.quantity -= quantity;
            _MobileContext.Update(product);
            _MobileContext.SaveChanges();
            return Ok(product);
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
