using System;
namespace Lession1
{
    class Array2
    {
        static void Main(string[] agrs){
            //Nested array
            int[][] matrix = new int[3][]
                                    { 
                                        new int[2] { 4,5}, 
                                        new int[3] {5,6,7 }, 
                                        new int[4] {3,4,6,7} 
                                    };
            for(int i=0; i< matrix.Length; i++){
                for(int j=0; j< matrix[i].Length; j++){
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }

            //two-dimensional array

            int[,] tda = new int[5,6];
            Random rnd = new Random();
            for(int i=0; i< tda.GetLength(0); i++){
                for(int j=0; j< tda.GetLength(1); j++){
                    tda[i,j] = rnd.Next(10,50);
                }
            }

            for(int i=0; i< tda.GetLength(0); i++){
                for(int j=0; j< tda.GetLength(1); j++){
                    Console.Write($"{tda[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}