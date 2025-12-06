class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static bool[] isPrime;

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        //int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int count = 0;
        Prime(N);
        List<int> primes = new List<int>();
        for (int i = 2; i <= N; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }
        int left = 0;
        int right = 0;
        int sum = 0;

        while (true)
        {

            if (sum >= N)
            {
                if (sum==N) 
                {
                    count++;
                }
                sum -= primes[left++];

            }
            else 
            {
                if (right >=primes.Count)
                {
                    break;
                }
                sum += primes[right++];
            }
          
        }

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

    static void Prime(int N) 
    {
        isPrime = new bool[N + 1];
        for (int i = 2; i <= N; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= N; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= N; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
    }
}
