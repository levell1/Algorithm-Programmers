
using System.ComponentModel.Design;
using System.Xml.Linq;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int N, K;
    static int min;
    static int last;
    static int[] time;
    static List<int>[] link;
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        while (T-->0)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            N = NK[0];
            K = NK[1];

            link = new List<int>[N + 1];

            for (int i = 1; i <= N; i++)
            {
                link[i] = new List<int>();
            }

            string[] inputTime = Console.ReadLine().Split();
            time = new int[inputTime.Length + 1];
            for (int i = 0; i < inputTime.Length; i++)
            {
                time[i + 1] = int.Parse(inputTime[i]);
            }

            int[] indeg = new int[N + 1];

            for (int i = 0; i < K; i++)
            {
                int[] node = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int u = node[0];
                int v = node[1];
                link[u].Add(v);
                indeg[v]++;
            }

            last = int.Parse(Console.ReadLine());

            int[] dp = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                dp[i] = time[i];
            }

            Queue<int> que = new Queue<int>();
            for (int i = 1; i <= N; i++)
            {
                if (indeg[i] == 0)
                {
                    que.Enqueue(i);
                }
            }

            while (que.Count > 0)
            {
                int u = que.Dequeue();
                foreach (var v in link[u])
                {
                    if (dp[v] < dp[u] + time[v])
                    {
                        dp[v] = dp[u] + time[v];
                    }
                    indeg[v]--;
                    if (indeg[v] == 0) que.Enqueue(v);
                }

            }

            sw.WriteLine(dp[last]);
        }

        
        sw.Flush(); sw.Close();
    }

}
