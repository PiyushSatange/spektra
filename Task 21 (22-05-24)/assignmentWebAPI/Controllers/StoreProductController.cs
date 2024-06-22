using assignmentWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreProductController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public StoreProductController(StoreContext dbContext)
        {
            _storeContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _storeContext.StoreProducts.ToList();
            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var product = _storeContext.StoreProducts.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpDelete]
        public IActionResult deleteById(int id)
        {
            var product = _storeContext.StoreProducts.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _storeContext.StoreProducts.Remove(product);
            _storeContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult add(StoreProduct product)
        {
            if (product == null)
            {
                return NotFound();
            }
            _storeContext.StoreProducts.Add(product);
            _storeContext.SaveChanges();
            return Ok(product);
        }

        [HttpPut]
        public IActionResult put(int id, StoreProduct product)
        {
            var pro = _storeContext.StoreProducts.Find(id);
            if (pro == null)
            {
                return NotFound();
            }
            pro = product;
            _storeContext.SaveChanges();
            return Ok();
        }
    }
}