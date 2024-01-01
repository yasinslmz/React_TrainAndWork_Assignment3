using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementWebApi.Models;
namespace ProductManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public static List<User> users = new List<User>()
        {
            new User(){Id=1,email="yasin@gmail.com",password="123",firstName="yasin",lastName="solmaz"}
        };


        [HttpGet]
        public List<User> Get()
        {
            return users;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] User value)
        {
            var user = users.FirstOrDefault(user => user.email == value.email && user.password == value.password);

            if (user != null)
            {
                return Ok(user); // 200 OK
            }
            else
            {
                return NotFound(); // 404 Not Found
            }
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] User value)
        {
            var user = users.FirstOrDefault(user => user.email == value.email && user.password == value.password);

            if (user == null)
            {
                int maxId = users.Max(u => u.Id);
                value.Id = maxId + 1;
                users.Add(value);
                return Ok();
            }
            else
            {
                return NotFound(); // 404 Not Found
            }
        }

    }
}
