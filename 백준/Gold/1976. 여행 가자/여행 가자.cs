

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int N ,M;
    static int[] parents;

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());

        parents = new int[N + 1];
        for (int i = 1; i <= N; i++)
        {
            parents[i] = i;
        }

        for (int i = 1; i <= N; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int j = 1; j <= N; j++)
            {
                if (line[j-1]==1)
                {
                    Union(i, j);
                }
                
            }

        }

        int[] plan = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 1; i < M; i++)
        {
            if (Find(plan[0]) != Find(plan[i]))
            {
                Console.WriteLine("NO");
                return;
            }
        }

        sw.WriteLine("YES");
        sw.Flush(); sw.Close();
    }

    static int Find(int x)
    {
        if (parents[x] == x) return x;
        return parents[x] = Find(parents[x]);
    }

    static void Union(int a, int b) 
    {
        a = Find(a);
        b = Find(b);
        if (a != b) parents[b] = a;
    }

}
