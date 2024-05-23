using System;
using System.Collections.Generic;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dont = false;
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());
            int addnum = 1;



            while (count>0)
            {
                int num = int.Parse(Console.ReadLine());

                if (!stack.Contains(num))
                {
                    for (int i = addnum; i < num+1; i++)
                    {
                        stack.Push(addnum);
                        sb.AppendLine("+");
                        addnum++;
                    }
                }

                if (stack.Contains(num))
                {
                    stack.Pop();
                    sb.AppendLine("-");
                }
                else
                {
                    dont = true;
                }

                count--;
            }

            if (dont)
            {
                sb.Clear();
                sb.Append("NO");
            }
            Console.Write(sb.ToString());
            Console.ReadLine();
        }
    }
}

