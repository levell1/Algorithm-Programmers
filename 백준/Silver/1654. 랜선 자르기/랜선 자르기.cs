using System;
using System.Linq;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] NK = Array.ConvertAll(input.Split(' '), Convert.ToInt32);

        int[] length = new int[NK[0]];

        for (int i = 0; i < NK[0]; i++)
        {
            length[i] = Convert.ToInt32(Console.ReadLine());
        }

        long left = 0;
        long right = length.Max();
        long result = 0;
        while (left <= right) 
        {
            long mid = (left + right) / 2;
            if (mid ==0)
            {
                mid = 1;
            }
            long count = 0;

            foreach (int n in length)
            {
                count += n / mid;
            }

            if (count >= NK[1])
            {
                result = mid;
                left = mid+1;
            }
            else
            {
                right = mid-1;
            }
        }

        Console.WriteLine(result);
        Console.ReadLine();

    }
}
