namespace SW.UserService.Repository
{
    using Microsoft.EntityFrameworkCore;
    using SW.UserService.Repository.Models;

    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> contextOptions) 
            : base(contextOptions)
        { 
        }

        public DbSet<UserDb> Users { get; set; }
        public DbSet<UserRolesDb> UserRoles { get; set; }
    }
}
