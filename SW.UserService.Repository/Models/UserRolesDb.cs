namespace SW.UserService.Repository.Models
{
    using SW.UserService.Repository.Enums;
    using System.ComponentModel.DataAnnotations;

    public class UserRolesDb
    {
        [Key]
        public int UserRoleId { get; set; }

        public UserRole UserRoleName { get; set; }
    }
}
