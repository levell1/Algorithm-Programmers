using System.Security;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int resultMin = 0;
        bool[] isPrime = new bool[max + 1];
        for (int i = 2; i <=max; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= max; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= max; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (int i = min; i <= max; i++)
        {
            if (isPrime[i])
            {
                sum += i;
                if (resultMin==0)
                {
                    resultMin = i;
                }
            }
        }
        if (sum==0)
        {
            sw.WriteLine(-1);
        }
        else
        {
            sw.WriteLine(sum);
            sw.Write(resultMin);
        }

        sw.Flush(); sw.Close();

    }
}
