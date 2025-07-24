
using System;

class Program
{
    static void Main()
    {

        var sw = new StreamWriter(Console.OpenStandardOutput());

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        a = (int)Math.Ceiling(Math.Sqrt(a));
        b = (int)Math.Floor(Math.Sqrt(b));

        int result = 0;
        int cur = 0;

        bool check = false;

        for (int i = b; i >= a; i--)
        {
            check = true;
            cur = i*i;
            result += i*i;
        }

        if (check)
        {
            sw.WriteLine(result);
            sw.WriteLine(cur);
        }
        else
        {
            sw.WriteLine(-1);
        }

        sw.Flush(); sw.Close();

    }

}