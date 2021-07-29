using System;
namespace Lession1
{
    class Methods
    {
        static void Main(string[] agrs){
            // Console.Write("Enter your name:");
            // string name = Console.ReadLine();
            // ShowName(name);


            // int number1 = 5;
            // int number2 = 7;
            // Console.WriteLine($"1. number1: {number1},number2: {number2}");
            // Swap(ref number1, ref number2, out int temp);
            // Console.WriteLine($"3. number1: {number1},number2: {number2}");
            // Console.WriteLine($"temp: {temp}");

            // int number1 = 5;
            // int number2 = 7;
            // Console.WriteLine(Sum(number1, number2,out int total));
            // Console.WriteLine(total);

            // Console.WriteLine(string.Join("-", GenerateArray(max:50,size:5, min:10)));
            // Console.WriteLine(string.Join(";", GenerateArray(5,80,100)));
            // Console.WriteLine(Sum(number2:5.6, number1:6.7));
            int[] array = GenerateArray(20, 10,80);
            foreach(int item in array){
                Console.Write($"{item} - {Array.IndexOf(array, item)} ");
            }

            Array.ForEach(array, new Action<int>(){
                
            })
        }
        static void ShowName(string name){
            Console.WriteLine(name);
        }

        // static int Swap(ref int number1,ref int number2){
        //     int temp = number1;
        //     number1 = number2;
        //     number2 = temp;
        //     Console.WriteLine($"2. number1: {number1},number2: {number2}");
        //     return temp;
        // }

        static void Swap(ref int number1,ref int number2, out int temp){
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"2. number1: {number1},number2: {number2}");
        }

        // static int Sum(int number1, int number2, out int total){
        //     number1*=2;
        //     number2*=2;
        //     total = number1+number2;
        //     return number1 + number2;
        // }
        static int Sum(int number1, int number2){
            return number1 + number2;
        }

        static int Sum(int number1){
            return number1 + number1;
        }

        static double Sum(double number1, double number2){
            return number1 + number2;
        }


        static int[] GenerateArray(int size, int min=20, int max=90){
            int[] arr = new int[size];
            Random rnd = new Random();
            for(int i=0; i< size; i++){
                arr[i] = rnd.Next(min, max);
            }
            return arr;
        }
    }
}