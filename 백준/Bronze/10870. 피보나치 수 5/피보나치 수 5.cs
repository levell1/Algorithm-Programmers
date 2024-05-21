using System;
namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());

            int Fibonacci(int num)
            {
                if (num == 1) return 1;
                else if (num == 0) return 0;

                num = Fibonacci(num - 1) + Fibonacci(num - 2);
                return num;
            }
            int result = Fibonacci(inputNum);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}