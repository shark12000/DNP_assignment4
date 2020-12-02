﻿using System;
 using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
 using Microsoft.EntityFrameworkCore.Metadata.Internal;

 namespace DoAPI.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }
        public int ChildId { get; set; }
        public int FamilyId { get; set; }
        [Required]
        public string PetSpecie { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        
        public void Update(Pet toUpdate) {
            Age = toUpdate.Age;
            PetSpecie = toUpdate.PetSpecie;
            Name = toUpdate.Name;
        }
        
    }
}
