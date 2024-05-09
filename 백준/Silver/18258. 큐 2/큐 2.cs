using System;
using System.Collections.Generic;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int back = 0;
            Queue<int> que= new Queue<int>();
            StringBuilder sb = new StringBuilder();

            var a = int.Parse(Console.ReadLine());
            
            while (count < a)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "push")
                {
                    back = int.Parse(input[1]);
                    que.Enqueue(back);
                    
                }
                else if (input[0] == "pop")
                {
                    if (que.Count > 0)
                    {
                        sb.Append(que.Dequeue() + "\n");
                    }
                    else
                    {
                        sb.Append("-1" + "\n");
                    }
                }
                else if (input[0] == "size")
                {
                    sb.Append(que.Count + "\n");
                }
                else if (input[0] == "empty")
                {
                    if (que.Count == 0)
                    {
                        sb.Append("1" + "\n");
                    }
                    else
                    {
                        sb.Append("0" + "\n");
                    }
                }
                else if (input[0] == "front")
                {
                    if (que.Count == 0)
                    {
                        sb.Append("-1" + "\n");
                    }
                    else
                    {
                        sb.Append(que.Peek() + "\n");
                    }
                }
                else if (input[0] == "back")
                {
                    if (que.Count == 0)
                    {
                        sb.Append("-1" + "\n");
                    }
                    else
                    {
                        sb.Append((back) + "\n");
                    }
                }
                count++;
            }

            Console.Write(sb.ToString());
            Console.ReadLine();
        }
    }
}

