using System;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int result = -1;
            if (inputNum == 3) {
                result = 1;
            }
            if (inputNum>=5)
            {
                if (inputNum % 5 == 0)
                {
                    result = inputNum / 5;
                }
                else if (inputNum % 5 == 1|| inputNum % 5 == 3)
                {
                    result = inputNum / 5 + 1;
                }
                else if (inputNum % 5 == 2|| inputNum % 5 == 4)
                {
                    result = inputNum / 5 + 2;
                }
            }
            if (inputNum == 7)
            {
                result = -1;
            }

            Console.Write(result);
            Console.ReadLine();
        }
    }
}
