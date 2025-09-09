
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[] parent;

    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = nm[0];
        int m = nm[1];

        parent = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            parent[i] = i;
        }

        for (int i = 0; i < m; i++) 
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int com = input[0];
            int a = input[1];
            int b = input[2];
            if (com==1)
            {
                if (Find(a)==Find(b))
                {
                    sw.WriteLine("YES");
                }
                else
                {
                    sw.WriteLine("NO");
                }
            }
            else
            {
                Union(a, b);
            }
        }

        sw.Flush(); sw.Close();
    }

    static int Find(int x)
    {
        if (parent[x] !=x)
        {
            parent[x] = Find(parent[x]);
        }
        return parent[x];
    }

    static void Union(int a, int b) 
    {
        a = Find(a);
        b = Find(b);

        if (a!=b)
        {
            if (a < b)
            {
                parent[b] = a;
            }else
            {
                parent[a] = b;
            }
        }
    }
}
