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
            var A = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            while (count <A) 
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "push")
                {
                    stack.Push(int.Parse(input[1]));
                }
                else if (input[0] == "pop")
                {
                    if (stack.Count > 0)
                    {
                        sb.Append(stack.Pop() + "\n");
                    }
                    else
                    {
                        sb.Append("-1" + "\n");
                    }
                }
                else if (input[0] == "size")
                {
                    sb.Append(stack.Count + "\n");
                }
                else if (input[0] == "empty") 
                {
                    if (stack.Count==0)
                    {
                        sb.Append("1" + "\n");
                    }
                    else
                    {
                        sb.Append("0" + "\n");
                    }
                }else if (input[0]=="top")
                {
                    if (stack.Count == 0)
                    {
                        sb.Append("-1" + "\n");
                    }
                    else
                    {
                        sb.Append(stack.Peek() + "\n");
                    }
                }
                count++;
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
