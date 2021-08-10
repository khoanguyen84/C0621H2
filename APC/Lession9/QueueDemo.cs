using System;
using System.Collections;
namespace Lession9
{
    class QueueDemo
    {
        public static void Main(){
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);

            foreach(var item in queue){
                Console.WriteLine(item);
            }
        }
    }
}