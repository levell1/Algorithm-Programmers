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

            if (num%400==0)
            {
                Console.WriteLine(1);
            }
            else if(num%100==0) 
            {
                Console.WriteLine (0);
            }
            else if (num%4 ==0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine (0);
            }



            Console.ReadLine();
        }
    }
}