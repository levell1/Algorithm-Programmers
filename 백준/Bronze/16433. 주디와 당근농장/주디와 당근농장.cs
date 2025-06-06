using System;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int n = inputArr[0];
        int r = inputArr[1];
        int c = inputArr[2];

        int baseParity = (r + c) % 2;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if ((i + j) % 2 == baseParity)
                    sw.Write('v');
                else
                    sw.Write('.');
            }
            sw.WriteLine();
        }

        sw.Flush(); sw.Close();
    }
}
