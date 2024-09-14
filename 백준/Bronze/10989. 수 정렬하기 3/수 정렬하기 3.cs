using System;
using System.IO;

class Program
{
    static void Main()
    {
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var sw = new StreamWriter(Console.OpenStandardOutput())
        {
            AutoFlush = false
        };

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
        sw.Flush();
        Console.ReadLine();
    }
}
