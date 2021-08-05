using System;
namespace ProductManagement
{
    class Shop
    {
        public Product[] ProductList = new Product[4]{
            new Product(){
                Name= "Coca",
                Description = "Coca desc",
                Price = 10000,
                Rate = new int[2] {4,5}
            },
            new Product(){
                Name= "Pepsi",
                Description = "Pepsi desc",
                Price = 12000,
                Rate = new int[3] {3,5, 4}
            },
            new Product(){
                Name= "Fruit Orange",
                Description = "Fruit Orange desc",
                Price = 15000,
                Rate = new int[3] {3,5, 4}
            },
            new Product(){
                Name= "Watermelon",
                Description = "Watermelon desc",
                Price = 20000,
                Rate = new int[3] {3,5, 4}
            },
        };

        public void AddProduct(){
            Console.Write("Enter product name:");
            var productName = Console.ReadLine();
            Console.Write("Enter description:");
            var description = Console.ReadLine();
            Console.Write("Enter price:");
            var price = double.Parse(Console.ReadLine());
            Console.Write("Enter rate value:");
            var rate = int.Parse(Console.ReadLine());

            var product = new Product(productName, description, price);

            Array.Resize(ref product.Rate, product.Rate.Length + 1);
            product.Rate[product.Rate.Length-1] = rate;

            Array.Resize(ref ProductList, ProductList.Length + 1);

            ProductList[ProductList.Length-1] = product;
        }

        public void IterateProductList(){
            // for(int i=0; i< ProductList.Length; i++){
            //     ProductList[i].ViewInfo();
            //     double total = 0;
            //     for(int j=0;j<ProductList[i].Rate.Length; j++){
            //         total += ProductList[i].Rate[j];
            //     }
            //     Console.WriteLine($"Average point: {total/ProductList[i].Rate.Length}");
            // }
            foreach(Product pdt in ProductList){
                pdt.ViewInfo();
                double total = 0;
                foreach(int value in pdt.Rate){
                    total += value;
                }
                Console.WriteLine($"Average point: {total/pdt.Rate.Length}");
            }
        }

        public void RemoveProduct(){
            Console.Write("Enter product name: ");
            var name = Console.ReadLine();
            int position = -1;
            for(int i=0; i< ProductList.Length; i++){
                if(string.Compare(ProductList[i].Name.ToLower(), name.ToLower())==0){
                    position = i;
                    break;
                }
            }
            if(position == -1){
                Console.WriteLine("Not found");
            }
            else{
                for(int i=position; i< ProductList.Length - 1; i++){
                    ProductList[i] = ProductList[i+1];
                }
                Array.Resize(ref ProductList, ProductList.Length-1);
                Console.WriteLine("Product has been removed successfuly");
                IterateProductList();
            }
        }

        public void SearchProduct(){
            Console.Write("Enter min price: ");
            var min = double.Parse(Console.ReadLine());
            Console.Write("Enter max price: ");
            var max = double.Parse(Console.ReadLine());
            
            bool exist = false;
            foreach(Product pdt in ProductList){
                if(pdt.Price >= min && pdt.Price <= max){
                    pdt.ViewInfo();
                    double total = 0;
                    foreach(int value in pdt.Rate){
                        total += value;
                    }
                    Console.WriteLine($"Average point: {total/pdt.Rate.Length}");
                    exist = true;
                }
            }
            if(!exist){
                Console.WriteLine($"Not found product which price between {min} and {max}");
            }
        }
    }
}