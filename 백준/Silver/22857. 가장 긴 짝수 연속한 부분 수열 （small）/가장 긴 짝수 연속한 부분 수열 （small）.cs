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

            int maxLength = 0;
            int left = 0;
            int countOdd = 0;

            for (int right = 0; right < inputNum[0]; right++)
            {
                if (sequence[right] % 2 == 1)
                {
                    countOdd++;
                }

                while (countOdd > inputNum[1])
                {
                    if (sequence[left] % 2 == 1)
                    {
                        countOdd--;
                    }
                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1 - countOdd);
            }

            Console.WriteLine(maxLength);
            Console.ReadLine();
        }
    }
}