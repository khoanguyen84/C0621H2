using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Models.Category
{
    public class Create
    {
        [Required]
        [StringLength(200)]
        [Display(Name = "Category name")]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(500)]
        public string Picture { get; set; }
    }
}
