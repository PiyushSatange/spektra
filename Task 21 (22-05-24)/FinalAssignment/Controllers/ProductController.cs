using FinalAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Store1Context _store1Context;

        public ProductController(Store1Context dbContext)
        {
            _store1Context = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _store1Context.Products;
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _store1Context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult post(Product product)
        {
            if (product == null)
            {
                return NotFound();
            }
            _store1Context.Products.Add(product);
            _store1Context.SaveChanges();
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult put(int id, Product product)
        {
            if (product == null)
            {
                return NotFound();
            }
            var prdct = _store1Context.Products.Find(id);
            if (prdct == null)
            {
                return NotFound();
            }
            prdct.Name = product.Name;
            prdct.Price = product.Price;
            prdct.Quantity = product.Quantity;
            prdct.Brand = product.Brand;
            _store1Context.Products.Update(prdct);
            _store1Context.SaveChanges();
            return Ok(prdct);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _store1Context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _store1Context.Products.Remove(product);
            _store1Context.SaveChanges();
            return Ok();
        }
    }
}
