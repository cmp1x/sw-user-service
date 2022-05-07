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
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    //Role
                    var admin = new UserRolesDb() { UserRoleId = 1, UserRoleName = "ADMIN" };
                    var moderator = new UserRolesDb() { UserRoleId = 1, UserRoleName = "MODERATOR" };
                    var teacher = new UserRolesDb() { UserRoleId = 1, UserRoleName = "TEACHER" };
                    var student = new UserRolesDb() { UserRoleId = 1, UserRoleName = "STUDENT" };

                    db.UserRoles.Add(admin);
                    db.UserRoles.Add(moderator);
                    db.UserRoles.Add(teacher);
                    db.UserRoles.Add(student);

                    //Users
                    db.Users.Add(new UserDb() { Id = "1", Username = "Nat", Role = new List<UserRolesDb>() { admin } });
                    db.Users.Add(new UserDb() { Id = "2", Username = "Ivan", Role = new List<UserRolesDb>() { student } });
                    db.SaveChanges();                }
            }
        }
    }
}
