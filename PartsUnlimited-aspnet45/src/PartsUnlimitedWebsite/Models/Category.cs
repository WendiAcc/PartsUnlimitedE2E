﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Category
    {
        //Github my third change
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}