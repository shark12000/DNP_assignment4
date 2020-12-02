using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dnp_assignment_4.Models
{
    public class Pet
    {

        [Key]
        public int PetId { get; set; }
        public int ChildId { get; set; }
        public int FamilyId { get; set; }
        [Required]
        public string PetSpecie { get; set; }

        [NotMapped]
        public string[] SpeciesOfPet { get; set; } =
        {
            "Dinosaur",
            "Dog",
            "Cat",
            "Turtle"
        };
       
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
