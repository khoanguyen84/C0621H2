using System.Collections.Generic;

namespace CGShop
{
    class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public override string ToString()
        {
            return $"{productId}\t{productName}\t\t\t{price}\t\t\t{quantity}";
        }
    }

    class ProductList
    {
        public List<Product> products { get; set; }
    }
}