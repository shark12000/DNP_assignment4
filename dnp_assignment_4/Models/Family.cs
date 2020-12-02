using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dnp_assignment_4.Models
{
    public class Family
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        
        public ICollection<Adult> Adults { get; set; } = new List<Adult>();
        public ICollection<Child> Children { get; set; }
        public ICollection<Pet> Pets { get; set; }
        
        public void UpdateFamily(Family toUpdate) {
            StreetName = toUpdate.StreetName;
            HouseNumber = toUpdate.HouseNumber;
        }
    }
}
