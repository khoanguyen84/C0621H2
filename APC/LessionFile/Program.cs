using System;
using System.IO;

namespace LessionFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string path = @"C:\CodeGym\Class\C0621H2\APC\LessionFile\Data";
            string fileName ="text.txt";
            Directory.CreateDirectory(@"C:\CodeGym\Class\C0621H2\APC\LessionFile\Data");
            // Directory.Delete(@"C:\CodeGym\Class\C0621H2\APC\LessionFile\Data");
            // using(StreamWriter sw = File.CreateText(Path.Combine(path,fileName))){
            //     sw.WriteLine("NET CORE");
            //}


            using(StreamReader sr = File.OpenText(Path.Combine(path,"list.txt"))){
                string line = string.Empty;
                int index = 0;
                // while(!string.IsNullOrEmpty(line = sr.ReadLine())){
                //     Console.WriteLine($"Line {++index} - {line}");
                // }
                while((line = sr.ReadLine()) != null){
                    Console.WriteLine($"Line {++index} - {line}");
                }
            }
        }
    }
}
