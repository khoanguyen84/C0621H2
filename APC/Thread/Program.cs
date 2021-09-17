using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Show1From10);
            // thread1.Priority = ThreadPriority.Highest;
            thread1.Start();
            // Console.Write($"Thread1 - {thread1.ManagedThreadId}");
            // Console.Write($"Main - {Thread.CurrentThread.ManagedThreadId}");
            
            thread1.Join();
            Thread thread2 = new Thread(Show10From20);
            thread2.Start();
            
            // for(int i=1;i<10;i++){
            //     Console.WriteLine($"T1-{i}");
            // }
            
        }

        public static void Show1From10(){
            for(int i=1;i<100;i++){
                Console.WriteLine($"T2-{i}");
            }
        }
        public static void Show10From20(){
            for(int i=100;i<200;i++){
                Console.WriteLine($"T3-{i}");
            }
        }
    }
}
