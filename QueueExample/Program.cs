using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> anQueue = new Queue<int>();
            anQueue.Enqueue(10);
            anQueue.Enqueue(20);
            anQueue.Enqueue(30);
            anQueue.Enqueue(40);
            anQueue.Enqueue(50);
            foreach (var data in anQueue)
            {
                Console.WriteLine(data);
            }

            anQueue.Dequeue();

            foreach (var data in anQueue)
            {
                Console.WriteLine(data);
            }

        }

    }
}
