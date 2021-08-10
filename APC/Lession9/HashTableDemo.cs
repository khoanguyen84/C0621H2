using System;
using System.Collections;
namespace Lession9
{
    class HashTableDemo
    {
        public static void Main(){
            Hashtable hashtable = new Hashtable();
            int[] odd = new int[] { 1,3,5,7,9};
            int[] even = new int[] {2,4,6,8,10};
            hashtable.Add("odd", odd);
            hashtable.Add("even", even);

            foreach(var value in hashtable.Values){
                Console.WriteLine(string.Join(',',(int[])value));
            }
        }
    }
}