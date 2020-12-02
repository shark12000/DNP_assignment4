using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dnp_assignment_4.Models
{
    public class Child : Person
    {
        [Key]
        public int ChildId { get; set; }
        [Required]
        public int FamilyId { get; set; }
        [NotMapped]
        public string[] Interests { get; set; } =
        {
            "Football", 
            "VideoGames", 
            "Puzzles", 
            "Drawing", 
            "Singing", 
            "Dancing"
        };
        
        public ICollection<Hobby> Hobbies { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
