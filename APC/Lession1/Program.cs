using System;
namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 5.5;
            int number2 = 5;
            // Console.WriteLine(number1 + "+" + number2 + "=" + (number1 + number2));
            Console.WriteLine($"{number1} + {number2} = {number1+number2}");
            Student a1 = new Student();
            Student a2 = new Student();
            a2.P1 = 5;
            a2.P2 = 7;
            a1 = a2;
            Console.Write($"{a1.P1}-{a1.P2}");
        }
        
    }

    
}
