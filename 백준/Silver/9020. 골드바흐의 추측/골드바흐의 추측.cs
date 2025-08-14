
using System.ComponentModel;

class Program
{
    static int n;
    static bool[] isPrime;

    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            isPrime = new bool[num + 1];

            FindPrims(num);

            int a = num / 2;
            int b = num / 2;

            while (true)
            {
                if (isPrime[a] && isPrime[b])
                {
                    sw.WriteLine($"{a} {b}");
                    break;
                }
                a--;
                b++;
            }
        }
    
        sw.Flush(); sw.Close();
    }


    static void FindPrims(int num) 
    {
        for (int i = 2; i <= num; i++)
        {
            isPrime[i] = true;
        }
        for (int i = 2; i*i <=num ; i++)
        {
            if (isPrime[i])
            {
                for (int j = i*i; j <= num; j+=i)
                {
                    isPrime[j] = false;
                }
            }
        }
    }
}
