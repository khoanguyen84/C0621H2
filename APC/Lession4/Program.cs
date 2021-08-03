using System;

namespace Lession4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dog bun = new Dog("Bum", 2, "Black");
            // Console.WriteLine(bun.ToString());
            // Console.WriteLine(bun.Info());

            // Animal pock = new Dog("Pock", 1, "Blue");

            Dog bun = new Dog("Bum", 2, "Black");
            Cat tom = new Cat("Tom",10, 4);

            Animal[] animals = new Animal[2] { bun, tom};
            for(int i=0; i < animals.Length; i++){
                if(animals[i].GetType().ToString() == "Lession4.Cat"){
                     Console.WriteLine($"Meo {((Cat)animals[i]).ToString()}");
                }
                else
                {
                    Console.WriteLine(animals[i].ToString());
                }
            }
        }
    }
}

