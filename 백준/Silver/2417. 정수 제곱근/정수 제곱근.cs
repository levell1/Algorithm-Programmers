using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main()
    {

        long input = long.Parse(Console.ReadLine());

        long left = 0;
        long right = input;
        long result = 0;


        while (left <= right)
        {
            long mid = (left + right) / 2;

            if (Math.Pow(mid,2)>= input)
            {
                result = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        Console.WriteLine(result);
        Console.ReadLine();
    }
}


