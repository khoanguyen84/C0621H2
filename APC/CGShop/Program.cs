using System;
using System.Collections.Generic;

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

            // cgShopService.ShowProduct();
            // Console.Write("Enter keyword: ");
            // var keyword = Console.ReadLine();
            // cgShopService.FindProduct(keyword);
            // cgShopService.FindBill(1);
            var billDetails = new List<BillDetail>();
            Console.Write("Enter Product ID:");
            var pdt1_Id = int.Parse(Console.ReadLine());
            var pdt1 = cgShopService.FindProductById(pdt1_Id);
            Console.Write("Enter quantity: ");
            var quantity1 = int.Parse(Console.ReadLine());
            var bd1 = new BillDetail(){
                Price = pdt1.price,
                ProductId = pdt1.productId,
                ProductName = pdt1.productName,
                Quantity = quantity1
            };
            billDetails.Add(bd1);
            Console.Write("Enter Product ID:");
            var pdt2_Id = int.Parse(Console.ReadLine());
            var pdt2 = cgShopService.FindProductById(pdt1_Id);
            Console.Write("Enter quantity: ");
            var quantity2 = int.Parse(Console.ReadLine());
            var bd2 = new BillDetail(){
                Price = pdt1.price,
                ProductId = pdt1.productId,
                ProductName = pdt1.productName,
                Quantity = quantity2
            };
            billDetails.Add(bd2);

            cgShopService.CreateBill(billDetails);
        }
    }
}
