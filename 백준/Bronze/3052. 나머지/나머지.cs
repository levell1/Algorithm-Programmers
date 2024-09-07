using System;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] a = new int[10];
        for (int i = 0; i < 10; i++)
        {
            string input = Console.ReadLine();
            a[i] = int.Parse(input)%42;
        }
        int[] b = a.Distinct().ToArray();

        Console.WriteLine(b.Length);

        Console.ReadLine();
    }
}
