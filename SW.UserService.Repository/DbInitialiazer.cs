namespace SW.UserService.Repository
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using SW.UserService.Repository.Enums;
    using SW.UserService.Repository.Models;

    public static class DbInitialiazer
    {
        public static void DbInitialize(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                using (var db = scope.ServiceProvider.GetService<UserDbContext>())
                {
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    //Role
                    db.UserRoles.Add(new UserRolesDb() { UserRoleName = UserRole.ADMIN });
                    db.UserRoles.Add(new UserRolesDb() { UserRoleName = UserRole.MODERATOR });
                    db.UserRoles.Add(new UserRolesDb() { UserRoleName = UserRole.STUDENT });
                    db.UserRoles.Add(new UserRolesDb() { UserRoleName = UserRole.TEACHER });
                    db.SaveChanges();

                    //Users
                    db.Users.Add(new UserDb() { Id = "1", Username = "Nat", UserRole = UserRole.ADMIN });
                    db.Users.Add(new UserDb() { Id = "2", Username = "Ivan", UserRole = UserRole.STUDENT });
                    db.SaveChanges();
                }
            }
        }
    }
}
