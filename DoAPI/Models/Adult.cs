﻿using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.Text.Json;

namespace DoAPI.Models
{
    public class Adult : Person
    {
        [Key]
        public int AdultId { get; set; }
        [Required]
        public int FamilyId { get; set; }
        [NotMapped]
        public string[] JobTitles { get; set; } =
        {
            "Teacher",
            "Engineer",
            "Programmer",
            "Captain",
            "Driver",
            "Superman",
            "Pirate",
            "Ninja",
            "Fireman"
        };
        [Required]
        public string JobTitle { get; set; }
        
        public void UpdateAdult(Adult toUpdate) {
            JobTitle = toUpdate.JobTitle;
            base.Update(toUpdate);
        }
    }
}
