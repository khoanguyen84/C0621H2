using System;

namespace ProductManagement
{
    class Program
    {
        private const int add = 1;
        private const int remove = 2;
        private const int show = 3;
        private const int search = 4;
        private const int exitCode = 5;
        private const int min = 1;
        private const int max = 5;
        private static Shop shop = new Shop();
        static void Main(string[] args)
        {
            Process();
        }
        private static void BuildMenu(out int selected)
        {
            int choose = 0;
            do
            {
                Console.WriteLine("========== CALCULATOR ==========");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Show Product");
                Console.WriteLine("4. Search Product");
                Console.WriteLine("5. Exit");
                Console.WriteLine("================================");
                Console.Write("Choose a function: ");
                int.TryParse(Console.ReadLine(), out choose);
            }
            while (choose < min || choose > max);
            selected = choose;
        }

        public static void Process()
        {
            int selected = 0;
            do{
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case add:{
                        shop.AddProduct();
                        break;
                    }
                    case remove:{
                        shop.RemoveProduct();
                        break;
                    }
                    case show:{
                        shop.IterateProductList();
                        break;
                    }
                    case search:{
                        shop.SearchProduct();
                        break;
                    }
                    case exitCode:{
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            while(selected != exitCode);
        }
    }
}
