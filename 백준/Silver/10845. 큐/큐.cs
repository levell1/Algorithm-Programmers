using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);
        Queue<int> q = new Queue<int>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < testcase; i++)
        {
            string inputq = Console.ReadLine();
            inputque(sb, inputq, q);
        }
        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }

    static void inputque(StringBuilder sb ,string input, Queue<int> queue)
    {
       
        string[] a = input.Split(' ');
        int num = 0;
        if (a[0] == "push")
        {
            num = Convert.ToInt32(a[1]);
            queue.Enqueue(num);
        }
        else if (a[0] == "pop") 
        {
            if (queue.Count > 0)
            {
                sb.AppendLine($"{queue.Dequeue()}");
            }
            else
            {
                sb.AppendLine("-1");
            }
        }
        else if (a[0] == "size")
        {
            sb.AppendLine($"{queue.Count}");
        }
        else if (a[0] == "empty")
        {
            if (queue.Count > 0)
            {
                sb.AppendLine("0");
            }
            else
            {
                sb.AppendLine("1");
            }
        }
        else if (a[0] == "front")
        {
            if (queue.Count > 0)
            {
                sb.AppendLine($"{queue.Peek()}");
            }
            else
            {
                sb.AppendLine("-1");
            }
        }
        else if (a[0] == "back")
        {
            if (queue.Count > 0)
            {
                sb.AppendLine($"{queue.Last()}");
            }
            else
            {
                sb.AppendLine("-1");
            }
        }

    }

}
