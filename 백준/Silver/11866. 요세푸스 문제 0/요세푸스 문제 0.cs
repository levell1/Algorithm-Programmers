using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] KN = Array.ConvertAll(input.Split(' '),Convert.ToInt32);
        Queue<int> q = new Queue<int>();
        
        for (int i = 1; i <= KN[0]; i++)
        {
            q.Enqueue(i);
        }
        Josephus(q, KN[0], KN[1]);

        Console.ReadLine();
    }

    static void Josephus(Queue<int> queue, int K, int N)
    {
        Console.Write("<");
        while (queue.Count > 1)
        {
            for (int i = 0; i < N-1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            Console.Write($"{queue.Dequeue()}, ");
        }

        Console.Write($"{queue.Dequeue()}>");

    }

}
