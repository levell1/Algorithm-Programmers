using System;
using System.Collections.Generic;
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
        HashSet<int> set = new HashSet<int>(a);
        int[] result = set.ToArray();

        Console.WriteLine(set.Count);

        Console.ReadLine();
    }
}
