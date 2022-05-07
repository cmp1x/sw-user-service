namespace SW.UserService.Repository
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using SW.UserService.Repository.Models;
    using System.Collections.Generic;

    public static class DbInitialiazer
    {
        public static void DbInitialize(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                using (var db = scope.ServiceProvider.GetService<UserDbContext>())
                {
                    //using (var transaction = db.Database.BeginTransaction())

                    //{
                        db.Database.EnsureDeleted();
                        db.Database.EnsureCreated();

                        //Role
                       // db.UserRoles.Add(new UserRolesDb() { UserRoleId = 1, UserRoleName = "ADMIN" });
                       // db.UserRoles.Add(new UserRolesDb() { UserRoleId = 2, UserRoleName = "MODERATOR" });
                       // db.UserRoles.Add(new UserRolesDb() { UserRoleId = 3, UserRoleName = "TEACHER" });
                       // db.UserRoles.Add(new UserRolesDb() { UserRoleId = 4, UserRoleName = "STUDENT" });
                       // db.SaveChanges();

                        //Users
                        db.Users.Add(new UserDb() { Id = "1", Username = "Nat", RoleId = 1 });
                        db.Users.Add(new UserDb() { Id = "2", Username = "Ivan", RoleId = 4 });
                        db.SaveChanges();
                    //}
                }
            }
        }
    }
}
