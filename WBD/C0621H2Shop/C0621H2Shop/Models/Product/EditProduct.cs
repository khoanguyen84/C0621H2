using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Models.Product
{
    public class EditProduct : CreateProduct
    {
        public int ProductId { get; set; }
        public string ExistPicture { get; set; }
    }
}
