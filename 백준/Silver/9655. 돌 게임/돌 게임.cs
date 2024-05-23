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
            if (inputNum % 2 == 0)
            {
                sb.Append("CY");
            }
            else 
            {
                sb.Append("SK");
            }

            Console.Write(sb.ToString());
            Console.ReadLine();
        }
    }
}
