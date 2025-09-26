
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static async Task Main()
    {

        int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = ab[0];
        int b = ab[1];

        int[] cd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int c = cd[0];
        int d = cd[1];

        int ac = a * d + c * b;
        int bd = b * d;

        int g = GCD(ac,bd);
        ac /= g;
        bd /= g;

        sw.WriteLine($"{ac} {bd}");
        sw.Flush(); sw.Close();
    }

    static int GCD(int x, int y) 
    {
        while (y!=0)
        {
            int temp = x % y;
            x = y;
            y = temp;
        }
        return x;
    }
}

