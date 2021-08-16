using System;
using System.IO;
using System.Linq;

namespace LessionFile
{
    class ArrayDemo
    {
        public static void Main(){
            string path = @"C:\CodeGym\Class\C0621H2\APC\LessionFile\Data";
            string fileInput ="input.txt";
            string fileOutput = "output.txt";

            // int[] array = GenerateArray(10, 10, 90);
            // using(StreamWriter sw = File.CreateText(Path.Combine(path, fileInput))){
            //     sw.WriteLine(10);
            //     sw.WriteLine(string.Join(' ', array));
            // }

            int[] array2;
            int size;
            using(StreamReader sr = File.OpenText(Path.Combine(path, fileInput))){
                string firstLine = sr.ReadLine();
                size = int.Parse(firstLine);
                array2 = new int[size];
                string secondLine = sr.ReadLine();
                array2 = secondLine.Split(" ").Select(v => int.Parse(v)).ToArray();
            }

            array2 = array2.Select(v => v*2).ToArray();

            using(StreamWriter sw = File.CreateText(Path.Combine(path, fileOutput))){
                sw.WriteLine(size);
                sw.WriteLine(string.Join(' ', array2));
            }
        }


        public static int[] GenerateArray(int size, int min, int max){
            int[] array = new int[size];
            Random rnd = new Random();
            for(int i=0;i<size;i++){
                array[i] = rnd.Next(min, max);
            }
            return array;
        }
    }
}