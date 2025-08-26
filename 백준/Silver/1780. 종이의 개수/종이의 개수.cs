
using System.Diagnostics.CodeAnalysis;

class Program
{
    static int N, K;
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[,] paper;
    static int[] result;
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        result = new int[3];
        paper = new int[N,N];
        for (int i = 0; i < N; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < N; j++)
            {
                paper[i, j] = line[j];
            }
        }
        Check(0, 0, N);

        foreach (var count in result)
        {
            sw.WriteLine(count);
        }
        
        sw.Flush(); sw.Close();
    }

    static void Check(int x, int y, int size) 
    {
        int cur = paper[x, y];

        for (int i = x; i < x+size; i++)
        {
            for (global::System.Int32 j = y; j < y+size; j++)
            {
                if (paper[i,j]!=cur)
                {
                    size /= 3;
                    Check(x, y, size);
                    Check(x, y + size, size);
                    Check(x, y + size * 2, size);
                    Check(x + size, y, size);
                    Check(x + size, y + size, size);
                    Check(x + size, y + size * 2, size);
                    Check(x + size * 2, y, size);
                    Check(x + size * 2, y + size, size);
                    Check(x + size * 2, y + size * 2, size);
                    return;
                }
            }
        }

        result[cur + 1]++;
    }
}
