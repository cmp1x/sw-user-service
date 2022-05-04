namespace SW.UserService.Core.Models
{
    using System;
    using SW.UserService.Core.Enums;

    class User
    {
        public string Id { get; set; }
        
        public int Cursor { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAt { get; set; }
        
        public string Username { get; set; }
        
        public string Email { get; set; }
        
        public string EncryptedPassword { get; set; }
        
        public UserRole Role { get; set; }
        
        public string ConfirmationToken { get; set; }
        
        public DateTime ConfirmedAt { get; set; }
        
        public string ResetPasswordToken { get; set; }
        
        public DateTime ResetPasswordTokenSentAt { get; set; }
        
        public string AvatarUrl { get; set; }
    }
}
