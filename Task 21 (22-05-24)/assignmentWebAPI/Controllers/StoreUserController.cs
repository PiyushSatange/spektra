using assignmentWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignmentWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreUserController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public StoreUserController(StoreContext dbContext)
        {
            _storeContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _storeContext.StoreUsers;
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var user = _storeContext.StoreUsers.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult deleteById(int id)
        {
            var user = _storeContext.StoreProducts.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            _storeContext.StoreProducts.Remove(user);
            _storeContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult add(StoreUser user)
        {
            if (user == null)
            {
                return NotFound();
            }
            _storeContext.StoreUsers.Add(user);
            _storeContext.SaveChanges();
            return Ok(user);
        }

        [HttpPut]
        public IActionResult put(int id, StoreUser user)
        {
            var usr = _storeContext.StoreUsers.Find(id);
            if (usr == null)
            {
                return NotFound();
            }
            usr = user;
            _storeContext.SaveChanges();
            return Ok();
        }
    }
}