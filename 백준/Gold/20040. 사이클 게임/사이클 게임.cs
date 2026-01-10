

using System.Threading.Tasks.Sources;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[] parents;

    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int n = nm[0];
        int m = nm[1];

        parents = new int[n];

        for (int i = 0; i < n; i++)
        {
            parents[i] = i;
        }
        int result = 0;
        for (int i = 1; i <= m; i++)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = ab[0];
            int b = ab[1];
            
            if (Find(a) == Find(b))
            {
                result = i;
                break;
            }
            Union(a, b);
        }



        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

    static int Find(int x) 
    {
        if (parents[x] ==x)
        {
            return x;
        }
        return parents[x] = Find(parents[x]);
    }

    static void Union(int a, int b) 
    {
        a = Find(a);
        b = Find(b);
        if (a!=b)
        {
            parents[b] = a;
        }
    }
}


