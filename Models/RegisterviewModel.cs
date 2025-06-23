using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
