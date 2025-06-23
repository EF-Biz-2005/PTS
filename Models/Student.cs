using System; 

using System.ComponentModel.DataAnnotations; 

  

namespace StudentManagementSystem.Models 

{ 

    public class Student 

    { 

        public int Id { get; set; } 

  

        [Required] 

        public required string Name { get; set; } 
        [Required]
        public int Age { get; set; }





  

        [Required] 

        public required string Course { get; set; } 

        [Required, EmailAddress] 

        public required string Email { get; set; } 

  

        [Display(Name = "Enrolment Date")] 

        [DataType(DataType.Date)] 

        public DateTime EnrolmentDate { get; set; } 

    } 

} 

 