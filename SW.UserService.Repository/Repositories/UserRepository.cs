namespace SW.UserService.Repository.Repositories
{
    using SW.UserService.Repository.Models;
    using System.Linq;

    public class UserRepository : IUserRepository
    {
        private UserDbContext db;

        public UserRepository(UserDbContext db)
        {
            this.db = db;
        }

        public IQueryable<UserDb> GetAll()
        {
            return this.db.Users;
        }

        public UserDb Get(string id)
        {
            return this.db.Users.FirstOrDefault(
                user => user.Id == id);
        }
    }
}
