using System;

namespace CGShop
{
    class Program
    {
        private static CGShopService cgShopService = new CGShopService();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // Console.Write("Enter product name: ");
            // var productName = Console.ReadLine();
            // Console.Write("Enter price: ");
            // var price = int.Parse(Console.ReadLine());
            // Console.Write("Enter quantity: ");
            // var quantity = int.Parse(Console.ReadLine());
            // var product = new Product(){
            //     price = price,
            //     productId = 0,
            //     productName = productName,
            //     quantity = quantity
            // };
            // var product = new Product(){
            //     price = 90000,
            //     productName = "Áo ba lổ",
            //     quantity = 75
            // };
            // var result = cgShopService.CreateProduct(product);
            // if(result){
            //     Console.Write("Product has been added successfully");
            // }else{
            //     Console.Write("Something went wrong, please contact administrator.");
            // }

            cgShopService.ShowProduct();
        }
    }
}
