using System.Text;

class Program
{
    static int n;
    static int[] field;
    static int result = 0;
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(Console.ReadLine());
        int[] A = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int[] B = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        Array.Sort(A);
        Array.Sort(B);
        Array.Reverse(B);

        int result = 0;

        for (int i = 0; i < n; i++)
        {
            result += A[i] * B[i];
        }

        sw.Write(result);
        sw.Flush(); sw.Close();

    }

}