namespace SW.UserService.Repository.Repositories
{
    using SW.UserService.Repository.Models;
    using System.Linq;

    public interface IUserRepository
    {
        UserDb Get(string id);

        IQueryable<UserDb> GetAll();
    }
}