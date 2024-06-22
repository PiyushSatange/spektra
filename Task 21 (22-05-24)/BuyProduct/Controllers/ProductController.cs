using BuyProduct.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuyProduct.Controllers
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
        public IActionResult GetAllProducts()
        {
            var products = _store1Context.Products;
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _store1Context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult buyProduct(int id, int qnt)
        {
            var product = _store1Context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            if(product.Quantity < qnt)
            {
                return NotFound("Qnantity is not available");
            }
            product.Quantity -= qnt;
            _store1Context.Products.Update(product);
            _store1Context.SaveChanges();
            return Ok(product);
        }
    }
}
