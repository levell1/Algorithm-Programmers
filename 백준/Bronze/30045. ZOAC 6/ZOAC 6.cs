using System;
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int input = Convert.ToInt32( Console.ReadLine());

        int result = 0;
        for (int i = 0; i < input; i++)
        {
            string str = Console.ReadLine();
            string str1 = "01";
            string str2 = "OI";
            if (str.Contains(str1)|| str.Contains(str2))
            {
                result++;
                continue;
            }
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }
}