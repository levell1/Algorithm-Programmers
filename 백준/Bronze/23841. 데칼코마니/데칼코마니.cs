
using System.Text;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int N = inputArr[0];
        int M = inputArr[1];

        StringBuilder[] result = new StringBuilder[N];

        for (int i = 0; i <N; i++)
        {
            string line = Console.ReadLine();
            result[i] = new StringBuilder(line);

            for (global::System.Int32 j = 1; j <= M/2; j++)
            {
                if (line[^j] != '.')
                {
                    result[i][j-1] = line[^j];
                }
            } 
            for (global::System.Int32 j = M / 2; j < M; j++)
            {
                result[i][j] = result[i][M - j -1];
            }

        }

        foreach (var item in result)
        {
            sw.WriteLine(item);
        }
        
        sw.Flush(); sw.Close();
    }

}