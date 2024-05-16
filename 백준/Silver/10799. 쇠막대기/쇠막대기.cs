using System;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            int answer = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    if (input[i+1]!=')')
                    {
                        count++;
                    }
                    else
                    {
                        answer += count;
                    }
                }
                if (input[i] == ')')
                {
                    if (input[i - 1] != '(')
                    {
                        count--;
                        answer += 1;
                    }
                }
            }

            Console.Write(answer);
            Console.ReadLine();
        }
    }
}