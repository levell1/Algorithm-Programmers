
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        string[] inputArr = Console.ReadLine().Split(" ");
        long start = long.Parse(inputArr[0]);
        long end = long.Parse(inputArr[1]);
        long sqrtEnd = (long)Math.Sqrt(end);

        bool[] isPrime = new bool[sqrtEnd + 1];
        for (int i = 2; i <= sqrtEnd; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= sqrtEnd; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= sqrtEnd; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        int count = 0;
        for (long i = 2; i <= sqrtEnd; i++)
        {
            if (isPrime[i])
            {
                for (long j = i * i; j <= end; j *= i)
                {
                    if (start <= j)
                    {
                        count++;
                    }
                    if (j > end / i) break;

                }
            }
        }

       

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }
}
