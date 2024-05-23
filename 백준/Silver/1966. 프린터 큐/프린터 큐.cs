using System;
using System.Collections.Generic;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Queue<(int, bool)> queue = new Queue<(int, bool)>();

            int count = 0;
            int max = 9;

            for (int i = 0; i < inputNum; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                string[] b = Console.ReadLine().Split(' ');
                for (int j = 0; j < int.Parse(a[0]); j++)
                {
                    int num = int.Parse(b[j]);
                    if (j == int.Parse(a[1]))
                    {
                        queue.Enqueue((num,true));
                    }
                    else
                    {
                        queue.Enqueue((num,false));
                    }
                }

                while (true)
                {
                    if (!(queue.Contains((max, true)) || queue.Contains((max, false))))
                    {
                        max--;
                    }
                    else if (queue.Peek() == (max, true))
                    {
                        count++;
                        queue.Clear();
                        break;
                    }
                    else if (queue.Peek() == (max, false))
                    {
                        queue.Dequeue();
                        count++;
                    }
                    else
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }

                sb.Append(count + "\n");
                count = 0;
                max = 9;
            }
            Console.Write(sb.ToString());
            Console.ReadLine();
        }
    }
}
