using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGymShop.Domain.Response
{
    public class ProductItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Manufactory { get; set; }
        public bool Status { get; set; }
        public string Photo { get; set; }
    }
}
