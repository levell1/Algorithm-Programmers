
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            long a = (long)inputArr[0];
            long b = (long)inputArr[1];

            long gcd = GCD(a,b) ;
            long lcm = LCM(a,b,gcd) ;

            sw.WriteLine(lcm);
        }

        sw.Flush(); sw.Close();


        long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        long LCM(long a, long b, long gcd) 
        {
            long result = a * b / gcd;
            return result;
        }
    }
}
