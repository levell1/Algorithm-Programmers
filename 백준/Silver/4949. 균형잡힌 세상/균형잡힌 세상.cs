using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            if (input ==".")
            {
                break;
            }
            stack.Push('1');
            foreach (char c in input)
            {
                if (c == '(' || c == ')' || c == '[' || c == ']')
                {
                    if (c == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (c == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
                if (c == '.')
                {
                    if (stack.Count == 1)
                    {
                        Console.WriteLine("yes");
                    }
                    else { Console.WriteLine("no"); }
                    stack.Clear();
                }
            }
        }


        Console.ReadLine();
    }

}
