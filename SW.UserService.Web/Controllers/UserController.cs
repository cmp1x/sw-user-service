namespace SW.UserService.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SW.UserService.Repository.Repositories;

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepository db;

        public UserController(IUserRepository db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.db.GetAll());
        }

        [HttpGet("Id")]
        public IActionResult GetId(string id)
        {
            var user = this.db.Get(id);

            if (!(user is null))
            {
                return Ok(user);
            }
            return NotFound("the ID not defined");
        }
    }
}
