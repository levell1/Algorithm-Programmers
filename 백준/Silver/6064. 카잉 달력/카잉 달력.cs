using System;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());


        int testcase = Convert.ToInt32(Console.ReadLine());


        for (int k = 0; k < testcase; k++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int M = input[0];
            int N = input[1];
            int x = input[2]-1;
            int y = input[3]-1;
            long count = -1;
            int num = x;

            while (num<=LCM(M,N))
            {
                if (num%N==y)
                {
                    count = num+1;
                    break;
                }
                num += M;
            }
            sw.WriteLine(count);

        }

        int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        int LCM(int a, int b) 
        {
            return(a * b) / GCD(a, b);
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}