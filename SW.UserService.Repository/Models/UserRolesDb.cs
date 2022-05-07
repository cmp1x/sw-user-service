namespace SW.UserService.Repository.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserRolesDb
    {
        [Key]
        public int UserRoleId { get; set; }

        public string UserRoleName {get;set;}
    }
}
