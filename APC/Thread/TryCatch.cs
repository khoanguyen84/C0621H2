using System;

namespace ThreadDemo
{
    class TryCatch
    {
        public static void Main(){
            try
            {
                int number1 = 10;
                int number2 = 1;
                Console.WriteLine(number1/number2);
                int[] number = new int[2] {1,2};
                Console.WriteLine(number[1]);
            }
            catch(DivideByZeroException e1){
                Console.WriteLine("Chia cho 0");
            }
            catch(IndexOutOfRangeException e2){
                Console.WriteLine("Ngoai phạm vi");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Completed");
            }
            // int number1 = 10;
            // int number2 = 0;
            // Console.Write(number1/number2);
            
        }
    }
}