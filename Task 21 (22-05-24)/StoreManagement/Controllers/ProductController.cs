using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Models;

namespace StoreManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        [HttpGet]
        public ActionResult GetAll()
        {
            var product = _storeContext.Products;
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            var product = _storeContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpDelete]
        public ActionResult deleteById(int id)
        {
            var product = _storeContext.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            _storeContext.Products.Remove(product);
            _storeContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public ActionResult add(Product product)
        {
            if(product == null)
            {
                return NotFound();
            }
            _storeContext.Products.Add(product);
            _storeContext.SaveChanges();
            return Ok(product);
        }

        [HttpPut]
        public ActionResult put(int id, Product product)
        {
            var pro = _storeContext.Products.Find(id);
            if(pro == null)
            {
                return NotFound();
            }
            pro = product;
            _storeContext.SaveChanges();
            return Ok();
        }
    }
}