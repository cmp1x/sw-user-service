namespace SW.UserService.Repository
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using SW.UserService.Repository.Repositories;

    public static class ServicesExtension
    {
        public static void AddRepositoryServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UserDbContext>(option => option.UseSqlServer(connectionString));

            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
