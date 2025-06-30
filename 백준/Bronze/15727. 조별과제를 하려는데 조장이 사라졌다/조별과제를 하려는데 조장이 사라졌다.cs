using System;
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int input = Convert.ToInt32( Console.ReadLine());

        int result = input / 5;
        if (input%5!=0)
        {
            result++;
        }

        sw.WriteLine(result);


        sw.Flush(); sw.Close();
    }
}