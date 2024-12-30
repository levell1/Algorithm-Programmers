using System.Collections;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int N = input[0];
        int M = input[1];

        int result = 0;

        var S = new HashSet<string>();

        for (int i = 0; i < N; i++)
        {
            S.Add(Console.ReadLine());
        }

        for (int i = 0; i < M; i++)
        {
            string find = Console.ReadLine();
            if (S.Contains(find))
            {
                result++;
            }
        }


        sw.Write(result);
        sw.Flush(); sw.Close();

    }
}
