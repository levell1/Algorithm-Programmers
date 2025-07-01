using System;
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int n = inputArr[0];
        int m = inputArr[1];
        int k = inputArr[2];

        int result = Math.Min(m, k) + Math.Min(n - m, n-k);

        sw.WriteLine(result);


        sw.Flush(); sw.Close();
    }
}