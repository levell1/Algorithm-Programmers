using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int A = inputArr[0];
        int B = inputArr[1];

        long mul = (long)A * (long)B;

        int a = A;
        int b = B;
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        long lcm = (A / a) * (long)B;
        
        sw.Write(lcm);


        sw.Flush(); sw.Close();
    }
}
