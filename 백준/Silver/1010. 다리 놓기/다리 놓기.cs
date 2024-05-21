using System;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            long[] results = new long[inputNum];
            for (int i = 0; i < inputNum; i++)
            {
                string[] testcase = Console.ReadLine().Split(' ');
                long first = long.Parse(testcase[0]);
                long second = long.Parse(testcase[1]);
                results[i] = combination(first, second);
                sb.Append(results[i] + "\n");
            }
            Console.Write(sb.ToString());
            Console.ReadLine();

            long combination(long first, long second)
            {

                long answer = 1;

                for (int i = 0; i < first; i++)
                {
                    answer *= second - i; // !second ~ (second - first) -> !second / !(second - first)
                    answer /= i + 1;      // !first
                }

                return answer;
            }
        }
    }
}