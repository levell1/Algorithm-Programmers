using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int sum = T;
        for (int i = 0; i < T-1; i++)
        {
            if (inputArr[i] % 2 == inputArr[i + 1] % 2)
            {
                sum--;
            }
            
        }

        sw.WriteLine(sum);

        sw.Flush(); sw.Close();
    }
}
