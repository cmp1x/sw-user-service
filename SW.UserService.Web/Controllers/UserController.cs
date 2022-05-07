namespace SW.UserService.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SW.UserService.Core.Models;

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IEnumerable<User> ExampleUsers;

        public UserController()
        {
            this.ExampleUsers = new List<User>()
            {
                new User()
                {
                    Id="22",
                    Username="Nat"
                }
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("Id")]
        public IActionResult GetId(string id)
        {
            var user = this.ExampleUsers.FirstOrDefault<User>(u => u.Id == id);

            if (!(user is null))
            {
                return Ok(user);
            }
            return NotFound("the ID not defined");
        }
    }
}
