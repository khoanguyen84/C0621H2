using System;
namespace Lession1
{
    class ArrayExample
    {
        static void Main(string[] agrs){
            // int[] array = new int[5] {5,6,7,8,9};

            // for(int i=0; i< array.Length; i++){
            //     Console.WriteLine(array[i]);
            // }

            // Array.Resize(ref array, 10);
            //Array.Resize(ref array, array.Length + 1);
            // array[array.Length-1] = 10;

            // for(int i=0; i< array.Length; i++){
            //     Console.WriteLine(array[i]);
            // }


            // int[] rndArray = new int[10];

            // Random rnd = new Random();

            // for(int i=0;i<rndArray.Length;i++){
            //     rndArray[i] = rnd.Next(20,90);
            // }

            // for(int i=0; i< rndArray.Length; i++){
            //     Console.WriteLine(rndArray[i]);
            // }

            // int number = 3;
            // if(number % 2 == 0){
            //     Console.WriteLine($"{number} là số chẵn");
            // }
            // else{
            //     Console.WriteLine($"{number} là số lẻ");
            // }
            // Console.WriteLine(number % 2 == 0 ? $"{number} là số chẵn" : $"{number} là số lẻ");
            string[] chuSo = new string[10] {"không","một","hai","ba","bốn","năm","sáu","bảy","tám","chín"};
            int number = 235345;
            int soDu = 0;
            string bangChu ="";
            while(number >0){
                soDu = number%10;
                number/=10;
                bangChu = $"{chuSo[soDu]} " + bangChu;
            } 
            Console.WriteLine(bangChu);
        }
    }
}