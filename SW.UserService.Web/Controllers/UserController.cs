namespace SW.UserService.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SW.UserService.Repository.Repositories;

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.userRepository.GetAll());
        }

        [HttpGet("Id")]
        public IActionResult GetId(string id)
        {
            var user = this.userRepository.Get(id);

            if (!(user is null))
            {
                return Ok(user);
            }
            return NotFound("the ID not defined");
        }
    }
}
