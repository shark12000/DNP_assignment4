using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace dnp_assignment_4.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string HairColor { get; set; }
        [Required]
        public string EyeColor { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public float Weight { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public string Sex { get; set; }
    }
}
