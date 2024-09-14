using System;
using System.IO;

class Program
{
    static void Main()
    {

        var sw = new StreamWriter(Console.OpenStandardOutput());

        int testcase = Convert.ToInt32(Console.ReadLine());
        int[] Narr= new int[100001];
        for (int i = 0; i < testcase; i++)
        {
            Narr[Convert.ToInt32(Console.ReadLine())]++;
        }
        for (int i = 1; i < Narr.Length; i++)
        {
            for (int j = 0; j < Narr[i]; j++)
            {
                sw.WriteLine(i);
            }
        }
        sw.Close();
        Console.ReadLine();
    }
}
