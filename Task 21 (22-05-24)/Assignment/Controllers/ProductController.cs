using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public ProductController(StoreContext dbContext)
        {
            _storeContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _storeContext.Products.ToList();
            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _storeContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

        [HttpDelete("{id}")]
        public IActionResult deleteById(int id)
        {
            var product = _storeContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _storeContext.Products.Remove(product);
            _storeContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult add(Product product)
        {
            if (product == null)
            {
                return NotFound();
            }
            _storeContext.Products.Add(product);
            _storeContext.SaveChanges();
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult put(int id, Product product)
        {
            var pro = _storeContext.Products.Find(id);
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
