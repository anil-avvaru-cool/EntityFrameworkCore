﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models
{
    public class Product
    {
        // Key attribute is optional if property is ending with Id or like ProductId
        // Generates Primary Key
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
