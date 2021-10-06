using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Models.Product
{
    public class DetailProduct : CreateProduct
    {
        public int ProductId { get; set; }
        [Display(Name = "Picture")]
        public string PicturePath { get; set; }
    }
}
