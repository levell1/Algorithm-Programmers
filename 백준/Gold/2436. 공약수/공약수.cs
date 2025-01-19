
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        string[] inputArr = Console.ReadLine().Split(" ");
        long gcd = long.Parse(inputArr[0]);
        long lcm = long.Parse(inputArr[1]);

        long mina = 100000000;
        long minb = 100000000;

        for (int i = 1; i <= Math.Sqrt(lcm/gcd); i++)
        {
            long a = gcd*i;
            long b = lcm * gcd / a;
            if (checkGcd(a,b)&&checkLcm(a,b))
            {
                if (a+b < mina+minb) 
                {
                    mina = a;
                    minb = b;
                }
            }
        }



        if (mina > minb) (mina, minb) = (minb, mina);
        sw.WriteLine($"{mina} {minb}");
        sw.Flush(); sw.Close();

        bool checkGcd(long a , long b) 
        {
            long temp = a;
            while (temp != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            if (a==gcd)
            {
                return true;
            }
            return false;
        }

        bool checkLcm(long a , long b) 
        {
            if (a * b / gcd==lcm)
            {
                return true;
            }
            return false;
        }
    }
}
