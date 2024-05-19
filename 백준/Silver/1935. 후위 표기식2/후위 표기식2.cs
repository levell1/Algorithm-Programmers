using System;
using System.Collections.Generic;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            int[] numArray = new int[inputNum];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Stack<decimal> stack = new Stack<decimal>();
            decimal num1;
            decimal num2;
            decimal result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    num1 = stack.Pop();
                    num2 = stack.Pop();
                    switch (input[i])
                    {
                        case '+':
                            result = num2 + num1;
                            break;
                        case '-':
                            result = num2 - num1;
                            break;
                        case '*':
                            result = num2 * num1;
                            break;
                        case '/':
                            result = num2 / num1;
                            break;
                    }
                    stack.Push(result);
                }
                else
                {
                    stack.Push(numArray[input[i]-'A']);
                }
            }
            Console.WriteLine(result.ToString("F2"));
            Console.ReadLine();
        }
    }
}