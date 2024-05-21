using System;
namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());

            decimal num = 0;
            decimal num2 = 1;
            decimal num3 = 1;
            for (int i = 0; i < inputNum - 1; i++)
            {
                num3 = num + num2;
                num = num2;
                num2 = num3;
            }
            if (inputNum == 0)
                num3 = 0;

            Console.WriteLine(num3);
            Console.ReadLine();
        }
    }
}