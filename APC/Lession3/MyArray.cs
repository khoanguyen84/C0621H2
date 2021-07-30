using System;

namespace Lession3
{
    class MyArray
    {
        public static int[] Resize(ref int[] array, int newLenght){
            Array.Resize(ref array, newLenght);
            return array;
        }
    }
}