using System;
using System.Text;
namespace Lession1
{
    class Prime
    {
        static void Main(string[] agrs){
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.Write("Nhập vào một số nguyên:");
            int.TryParse(Console.ReadLine(),out int number);
            Console.WriteLine(number);
        }
    }
}