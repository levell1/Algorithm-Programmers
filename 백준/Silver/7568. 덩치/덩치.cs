using System;
using System.Text;
using System.Threading;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);
        int[,] ints = new int[testcase,2];
        int count = 0;
        for (int i = 0; i < testcase; i++)
        {
            string kgcm = Console.ReadLine();
            string[] strings = kgcm.Split(' ');
            ints[i,0] = Convert.ToInt32(strings[0]);
            ints[i, 1] = Convert.ToInt32(strings[1]);
        }

        for (int i = 0; i < testcase; i++)
        {
            count = 1;
            for (global::System.Int32 j = 0; j < testcase; j++)
            {
                if (ints[i, 0] < ints[j,0]&& ints[i, 1] < ints[j, 1])
                {
                    count++;
                }
            }
            Console.Write($"{count} ");
        }

        Console.ReadLine();
    }
    
}
