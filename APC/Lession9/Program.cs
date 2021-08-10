using System;
using System.Collections;

namespace Lession9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(5);
            // al.Add("CodeGym");
            al.Add(5);
            al.Add(5);
            al.Add(5);
            al.Add(5);
            al.Add(5);
            al.Add(5);
            al.Add(5);
            int[] arr = new int[3]{ 6, 7,8};
            al.AddRange(arr);
            ArrayList al2 = (ArrayList)al.Clone();
            al.Equals(al2);
            // al.IndexOf("CodeGym");
            // al.Insert(1, "Hue");
            // al.Remove("Hue");
            // al.RemoveAt(1);
            // al.RemoveRange(2,7);
            al.Sort();
            al.Reverse();

            foreach(var item in al){
                Console.WriteLine(item);
            }
            al.IndexOf(7);
            // Console.WriteLine($"Count: {al.Count}");
            // Console.WriteLine($"Capacity: {al.Capacity}");
            // Console.WriteLine($"CodeGym: {al.IndexOf("CodeGym")}");
        }
    }
}
