using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            
            int[] inputNum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] dp = new int[inputNum[0]];
            int[] sequence = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //lis알고리즘

            int max = 0;
            int left = 0;
            int count = 0;

            for (int right = 0; right < inputNum[0]; right++)
            {
                if (sequence[right] % 2 == 1)
                {
                    count++;
                }

                while (count > inputNum[1])
                {
                    if (sequence[left] % 2 == 1)
                    {
                        count--;
                    }
                    left++;
                }

                max = Math.Max(max, right - left + 1 - count);
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}