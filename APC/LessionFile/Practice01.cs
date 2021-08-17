using System.IO;
using System.Linq;
using System;

namespace LessionFile
{
    class Practice01
    {
        public static void Main()
        {
            string path = @"C:\CodeGym\Class\C0621H2\APC\LessionFile\Data";
            string fileinput = "inputdata.txt";
            string fileoutput = "outputdata.txt";
            int[][] matrix = ReadFile(path, fileinput);
            ShowMatrix(matrix);
            WriteFile(path, fileoutput, matrix);
        }

        private static void ShowMatrix(int[][] matrix)
        {
            int row = matrix.Length;
            int column = matrix[0].Length;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static int[][] ReadFile(string path, string fileinput)
        {
            using (StreamReader sr = File.OpenText(Path.Combine(path, fileinput)))
            {
                string line = sr.ReadLine();
                string[] rowcol = line.Split(" ");
                int row = int.Parse(rowcol[0]);
                int column = int.Parse(rowcol[1]);
                int[][] matrix = new int[row][];
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    int[] arr = new int[column];
                    arr = line.Split(" ").Select(v => int.Parse(v)).ToArray();
                    matrix[i] = arr;
                    i++;
                }
                return matrix;
            }
        }

        private static int TotalMatrix(int[][] matrix){
            int row = matrix.Length;
            int column = matrix[0].Length;
            int total = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    total += matrix[i][j];
                }
            }
            return total;
        }

        private static int TotalPrimes(int[][] matrix){
            int row = matrix.Length;
            int column = matrix[0].Length;
            int total = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(IsPrime(matrix[i][j])){
                        total ++;
                    }
                }
            }
            return total;
        }

        private static bool IsPrime(int number){
            for(int i=2;i<=Math.Sqrt(number);i++){
                if(number%i != 0)
                    return false;
            }
            return true;
        }

        private static void WriteFile(string path, string fileoutput, int[][] maxtrix){
            using(StreamWriter sw = File.AppendText(Path.Combine(path,fileoutput))){
                sw.WriteLine($"Total matrix : {TotalMatrix(maxtrix)}");
                sw.WriteLine($"Total primes in matrix : {TotalPrimes(maxtrix)}");
            }
        }
    }
}
