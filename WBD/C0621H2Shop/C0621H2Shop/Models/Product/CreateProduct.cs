﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Models.Product
{
    public class CreateProduct
    {
        [Required]
        [StringLength(300)]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Pictures { get; set; }
        public int CategoryId { get; set; }
    }
}
