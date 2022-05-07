namespace SW.UserService.Repository.Models
{
    using SW.UserService.Repository.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserDb
    {
        [Key]
        public string Id { get; set; }

        public int Cursor { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string EncryptedPassword { get; set; }

        [ForeignKey("UserRolesDb")]
        public UserRole UserRole { get; set; }

        public string ConfirmationToken { get; set; }

        public DateTime ConfirmedAt { get; set; }

        public string ResetPasswordToken { get; set; }

        public DateTime ResetPasswordTokenSentAt { get; set; }

        public string AvatarUrl { get; set; }
    }
}
