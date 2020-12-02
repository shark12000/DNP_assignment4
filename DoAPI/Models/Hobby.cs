using System.ComponentModel.DataAnnotations;

namespace DoAPI.Models
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