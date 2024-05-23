using System;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int result = inputNum / 5;
            int remain = inputNum % 5;
            if (inputNum == 3) {
                result = 1;
            }
            if (inputNum>=5)
            {
                if (remain == 1|| remain == 3)
                {
                    result += 1;
                }
                else if (remain == 2|| remain == 4)
                {
                    result += 2;
                }
            }
            if (inputNum == 7 || inputNum == 4)
            {
                result = -1;
            }

            Console.Write(result);
            Console.ReadLine();
        }
    }
}
