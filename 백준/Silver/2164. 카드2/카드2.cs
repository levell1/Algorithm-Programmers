using System;
using System.Collections.Generic;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            
            for (int i = 1; i <= input; i++)
            {
                queue.Enqueue(i);
            }
            while (queue.Count > 1) 
            {
                queue.Dequeue();
                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine(queue.Dequeue());
            Console.ReadLine();
        }
    }
}