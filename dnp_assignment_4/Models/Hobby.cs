using System.ComponentModel.DataAnnotations;

namespace dnp_assignment_4.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyId { get; set; }
        [Required]
        public int ChildId { get; set; }
        [Required]
        public string HobbyType { get; set; }
    }
}