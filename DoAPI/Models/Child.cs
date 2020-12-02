﻿using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.Text.Json;

namespace DoAPI.Models
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
