using System;
using System.Linq;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string backwards;
            while (true) 
            {
                string input = Console.ReadLine();

                if (input == "END") 
                {
                    break;
                }
                backwards = new string(input.Reverse().ToArray());
                sb.AppendLine(backwards);
            }
            Console.Write(sb.ToString());
            Console.ReadLine();
        }
    }
}