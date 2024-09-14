using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = int.Parse(input);

        for (int i = 0; i < testcase; i++)
        {
            string inputk = Console.ReadLine();
            string inputn = Console.ReadLine();
            int k = int.Parse(inputk);
            int n = int.Parse(inputn);

            int[] ints = new int[n];
            for (int j = 0; j < n; j++)
            {
                ints[j] = 1;
            }

            for (int j = 0; j <= k; j++)
            {
                for (int l = 1; l< n; l++)
                {
                    ints[l] += ints[l - 1];
                }
            }
            Console.WriteLine(ints[n-1]);
        }

        

        Console.ReadLine();
    }
}
