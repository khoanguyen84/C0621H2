using System;
using System.Collections;
namespace Lession9
{
    class SortListDemo
    {
        public static int increment = 1 ;
        public static void Main(){
            SortedList sl = new SortedList();
            sl.Add(increment++, "Nam");
            sl.Add(increment++, "Huy");
            sl.Add(increment++, "Chinh");
            
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            sl.Add(increment++, name);
            foreach(var item in sl.Values){
                Console.WriteLine(item);
            }
        }
    }
}