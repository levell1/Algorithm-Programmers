
using System.Numerics;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        
        //int input = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int A= inputArr[0];
        int B = inputArr[1];
        sw.WriteLine($"{(A + B) * (A - B)}");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}
