using Microsoft.AspNetCore.Identity; 
namespace StudentManagementSystem.Models 
{
    public class User : IdentityUser
    { 
        public required string Email { get; set; }
        public required string Password { get; set; }
    } 
} 

 