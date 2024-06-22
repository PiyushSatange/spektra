using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Assignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public UserController(StoreContext dbContext)
        {
            _storeContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _storeContext.Users.ToList();
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _storeContext.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteById(int id)
        {
            var user = _storeContext.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            _storeContext.Users.Remove(user);
            _storeContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult add(User user)
        {
            if (user == null)
            {
                return NotFound();
            }
            _storeContext.Users.Add(user);
            _storeContext.SaveChanges();
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult put(int id, User user)
        {
            var usr = _storeContext.Users.Find(id);
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
