using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] MN = Array.ConvertAll(input.Split(' '), Convert.ToInt32);
        int M = MN[0];
        int N = MN[1];


        bool[] isPrime = new bool[N+1];
        for (int i = 2; i <= N; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= N; i++)
        {
            if (isPrime[i])
            {
                // I의 배수를 소수에서 제외
                for (int j = i * i; j <= N; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (int i = M; i < N+1; i++)
        {
            if (isPrime[i])
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();
    }
}