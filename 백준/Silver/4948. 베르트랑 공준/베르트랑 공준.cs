
class Program
{

    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int n = 1;
        int result;
        while ((n = Convert.ToInt32(Console.ReadLine()))!=0)
        {
            result = 0;
            for (int i = n+1; i <= n*2; i++)
            {
                if (IsPrime(i))
                {
                    result++;
                }
            }
            sw.WriteLine(result);
        }

        
        sw.Flush(); sw.Close();
    }

    static bool IsPrime(int num) 
    {
        if (num==1)
        {
            return false;
        }
        if(num==2)
        {
            return true;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}