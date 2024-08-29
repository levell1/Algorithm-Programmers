using System;
using System.Text;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            Console.Clear();

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                sb.AppendLine(i.ToString());
            }

            Console.Write(sb.ToString());
            Console.ReadLine();
        }
    }
}