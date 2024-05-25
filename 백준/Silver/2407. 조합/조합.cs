using System;
using System.Numerics;
using System.Text;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            BigInteger results = 0;

            string[] testcase = Console.ReadLine().Split(' ');
            int first = int.Parse(testcase[0]);
            int second = int.Parse(testcase[1]);
            results = combination(first, second);
            sb.Append(results + "\n");

            Console.Write(sb.ToString());
            Console.ReadLine();

            BigInteger combination(int firstnum, int secondnum)
            {
                BigInteger answer = 1;
                for (int i = 0; i < secondnum; i++)
                {
                    answer *= firstnum - i; // !second ~ (second - first) -> !second / !(second - first)
                    answer /= i + 1;      // !first
                }
                return answer;
            }
        }
    }
}