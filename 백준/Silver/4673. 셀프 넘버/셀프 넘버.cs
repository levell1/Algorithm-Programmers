

using System.Diagnostics.CodeAnalysis;

class Program
{
    static bool[] check = new bool[10001];

    static void Main()
    {

        var sw = new StreamWriter(Console.OpenStandardOutput());


        for (int i = 1; i <= 10000; i++)
        {
            int result = d(i);
            if (result<=10000)
            {
                check[result] = true;
            }
        }

        for (int i = 1; i < 10000; i++)
        {
            if (!check[i])
            {
                sw.WriteLine(i);
            }
        }

        sw.Flush(); sw.Close();

    }

    static int d(int n) 
    {
        int sum = n;
        while (n>=1)
        {
            sum += n% 10;
            n /= 10;
        }
        return sum;
    }

}