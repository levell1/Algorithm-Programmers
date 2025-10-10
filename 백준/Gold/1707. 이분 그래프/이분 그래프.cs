

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static bool[] visited;
    static List<int>[] list;
    static int[] color;
    static bool check;
    static void Main()
    {

        //int[] knm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int v = ve[0];
            int e = ve[1];
            visited = new bool[v + 1];
            list = new List<int>[v + 1];
            for (int j = 1; j < v + 1; j++)
            {
                list[j] = new List<int>();
            }
            for (int j = 0; j < e; j++)
            {
                int[] edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                list[edge[0]].Add(edge[1]);
                list[edge[1]].Add(edge[0]);
            }

            color = new int[v + 1];
            check = true;

           
            for (int j = 1; j < v+1; j++)
            {
                if (color[j]==0)
                {
                    DFS(j, 1);
                }
            }


            sw.WriteLine(check ? "YES" : "NO");
        }
       
        sw.Flush(); sw.Close();
    }

    static void DFS(int start,int c) 
    {
        color[start] = c;

        for (int i = 0; i < list[start].Count; i++)
        {
            int cur = list[start][i];
            if (color[cur]==0)
            {
                DFS(cur,-c);
            }else if (color[cur]==c)
            {
                check = false;
            }
        }
    }
}
