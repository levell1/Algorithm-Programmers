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
            if (num>=90)
            {
                Console.WriteLine('A');
            }
            else if (num>=80)
            {
                Console.WriteLine('B');
            }
            else if (num >= 70)
            {
                Console.WriteLine('C');
            }
            else if (num >= 60)
            {
                Console.WriteLine('D');
            }
            else 
            {
                Console.WriteLine('F');
            }

            Console.ReadLine();
        }
    }
}