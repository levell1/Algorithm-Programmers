
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
                long power = i * i; 
                while (power <= end)
                {
                    if (power >= start) count++;
                    if (power > end / i) break; 
                    power *= i;
                }
            }
        }

       

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }
}
