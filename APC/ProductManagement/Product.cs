using System;
namespace ProductManagement
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int[] Rate = new int[0];

        public Product()
        {
            
        }
        public Product(string name, string desc, double price)
        {
            Name = name;
            Description = desc;
            Price = price;
        }
        public void ViewInfo()
        {
            Console.WriteLine($"Name: {Name}\t\tDescription: {Description}\t\tPrice: {Price}");
        }
    }
}