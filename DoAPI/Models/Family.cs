﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;

 namespace DoAPI.Models
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
        public ICollection<Child> Children { get; set; } = new List<Child>();
        public ICollection<Pet> Pets { get; set; } = new List<Pet>();
        
        public void UpdateFamily(Family toUpdate) {
            StreetName = toUpdate.StreetName;
            HouseNumber = toUpdate.HouseNumber;
        }
    }
}
