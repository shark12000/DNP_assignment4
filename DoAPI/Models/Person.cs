﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DoAPI.Models
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
        
        public void Update(Person toUpdate) {
            Age = toUpdate.Age;
            Height = toUpdate.Height;
            HairColor = toUpdate.HairColor;
            Sex = toUpdate.Sex;
            Weight = toUpdate.Weight;
            EyeColor = toUpdate.EyeColor;
            FirstName = toUpdate.FirstName;
            LastName = toUpdate.LastName;
        }

    }
}
