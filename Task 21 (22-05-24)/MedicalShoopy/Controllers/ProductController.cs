using MedicalShoopy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalShoopy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MedicalShopContext _context;

        public ProductController(MedicalShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Products = _context.Products;
            if(Products == null)
            {
                return NotFound("the list is null");
            }
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Product = _context.Products.Find(id);
            if(Product == null)
            {
                return NotFound("the product with this id is not available");
            }
            return Ok(Product);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            if(product == null)
            {
                return BadRequest("The product is null here");
            }
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpPut("{id}")] 
        public IActionResult Put(int id, Product product) 
        { 
            if(id != product.Id)
            {
                return BadRequest("The id is not matching");
            }
            if(product == null)
            {
                return BadRequest("Null product can not be inserted");
            }
            var ExistingProduct = _context.Products.Find(id);
            if(ExistingProduct == null)
            {
                return NotFound("The id is not present to update");
            }
            ExistingProduct.Src = product.Src;
            ExistingProduct.Price = product.Price;
            ExistingProduct.Title = product.Title;
            ExistingProduct.Rating = product.Rating;
            ExistingProduct.Details = product.Details;
            _context.Products.Update(ExistingProduct);
            _context.SaveChanges();
            return Ok(ExistingProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Product = _context.Products.Find(id);
            if(Product == null)
            {
                return NotFound("Product with this id is not available");
            }
            _context.Products.Remove(Product);
            _context.SaveChanges();
            return Ok(Product);
        }

        [HttpPut("reduceQuantity/{id}")]
        public IActionResult ReduceQuantity(int id, int quantity)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound("Product with this id is not available");
            }
            if(product.Quantity < quantity)
            {
                return BadRequest("The quantity is not available");
            }
            product.Quantity -= quantity;
            _context.Update(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }
}
