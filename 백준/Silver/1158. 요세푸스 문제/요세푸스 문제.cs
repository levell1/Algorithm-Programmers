using System;
using System.Collections.Generic;
using System.Text;


namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int permutation1 = int.Parse(input[0]);
            int permutation2 = int.Parse(input[1]);
            Queue<int> queue = new Queue<int>();
            int count = 0;
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < permutation1; i++) 
            {
                queue.Enqueue(i+1);
            }

            sb.Append("<");
            
            while (permutation1>count) 
            {
                if (queue.Count == 1)
                {
                    sb.Append(queue.Dequeue()+ ">");
                    break;
                }
                for (int i = 1; i< permutation2; i++) 
                {
                    queue.Enqueue(queue.Dequeue());
                }
                sb.Append(queue.Dequeue() + ", ");
                
                count++;
            }
                   
            Console.Write(sb.ToString());
            Console.ReadLine();
        }
    }
}