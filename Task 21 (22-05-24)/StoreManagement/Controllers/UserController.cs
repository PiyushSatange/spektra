using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Models;

namespace StoreManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        [HttpGet]
        public ActionResult<User> GetAll()
        {
            var users = _storeContext.Users;
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            var user = _storeContext.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpDelete]
        public ActionResult deleteById(int id)
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
        public ActionResult add(User user)
        {
            if (user == null)
            {
                return NotFound();
            }
            _storeContext.Users.Add(user);
            _storeContext.SaveChanges();
            return Ok(user);
        }

        [HttpPut]
        public ActionResult put(int id, User user)
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