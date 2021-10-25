using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGymShop.API.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(250)]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [MaxLength(250)]
        public string Manufactory { get; set; }
        [Required]
        public bool Status { get; set; }
        public string Photo { get; set; }
    }
}
