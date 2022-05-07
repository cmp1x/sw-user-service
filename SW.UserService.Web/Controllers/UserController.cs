namespace SW.UserService.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SW.UserService.Repository;
    using SW.UserService.Repository.Models;
    using System.Linq;

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private UserDbContext db;

        public UserController(UserDbContext db)
        {
            this.db = db;
            this.db.Database.EnsureDeleted();
            this.db.Database.EnsureCreated();
            this.db.SaveChanges();
            this.db.Users.Add(
                new UserDb()
                {
                    Id = "22",
                    Username = "Nat"
                });
            this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("Id")]
        public IActionResult GetId(string id)
        {
            var user = this.db.Users.ToList().FirstOrDefault<UserDb>(
                usr => usr.Id == id);

            if (!(user is null))
            {
                return Ok(user);
            }
            return NotFound("the ID not defined");
        }
    }
}
