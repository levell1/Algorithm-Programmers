using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {
        string inputcase= Console.ReadLine();
        int testcase = Convert.ToInt32(inputcase);

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < testcase; i++)
        {
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            if (num == 0)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }

            }else
            {
                stack.Push(num);
            }
        }
        long sum = 0;
        foreach (var item in stack)
        {
            sum += item;
        }


        Console.WriteLine(sum);

        Console.ReadLine();
    }

}
