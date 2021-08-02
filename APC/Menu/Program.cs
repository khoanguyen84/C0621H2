using System;

namespace Menu
{
    class Program
    {
        private const int addition = 1;
        private const int subtract = 2;
        private const int multiple = 3;
        private const int division = 4;
        private const int exitCode = 5;
        private const int min = 1;
        private const int max = 5;
        static void Main(string[] args)
        {
            Process();
        }

        private static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("========== CALCULATOR ==========");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiple");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("================================");
                Console.Write("Choose a function: ");
                int.TryParse(Console.ReadLine(), out selected);
            }
            while (selected < min || selected > max);
        }

        public static void Process()
        {
            int selected = 0;
            do{
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case addition:{
                        int number1 = EnterNumber("Enter number 1: ");
                        int number2 = EnterNumber("Enter number 2: ");
                        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                        break;
                    }
                    case subtract:{
                        int number1 = EnterNumber("Enter subtrahend: ");
                        int number2 = EnterNumber("Enter minus: ");
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                        break;
                    }
                    case multiple:{
                        int number1 = EnterNumber("Enter number 1: ");
                        int number2 = EnterNumber("Enter number 2: ");
                        Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
                        break;
                    }
                    case division:{
                        int number1 = EnterNumber("Enter devided: ");
                        int number2 = EnterNumber("Enter devisor: ");
                        if(number2 == 0){
                            Console.WriteLine("Divided by zero.");    
                        }
                        else{
                            Console.WriteLine($"{number1} : {number2} = {(double)number1 / (double)number2}");
                        }
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
        
        public static int EnterNumber(string msg){
            int number =0;
            bool isNumber = true;
            do{
                Console.Write(msg);
                isNumber = int.TryParse(Console.ReadLine(), out number);
            }
            while(!isNumber);
            return number;
        }
    }
}
