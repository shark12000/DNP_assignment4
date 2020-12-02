using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dnp_assignment_4.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
        public ICollection<Family> Families { get; set; } 
    }
}