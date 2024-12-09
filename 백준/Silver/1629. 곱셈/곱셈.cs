
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        long a = inputArr[0];
        long b = inputArr[1];
        long c = inputArr[2];

        sw.Write(PowMod(a,b,c));
        sw.Flush(); sw.Close();
        Console.ReadLine();


        long PowMod(long a, long b, long c)
        {
            if (b == 0) return 1;
            long half = PowMod(a, b / 2, c) % c;
            long result = (half * half) % c;

            if (b % 2 == 1)
            {
                result = (result * (a % c)) % c;
            }

            return result;
        }
    }
}