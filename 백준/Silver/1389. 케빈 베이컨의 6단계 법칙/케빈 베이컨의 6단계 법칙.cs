
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int users = input[0];
        int con = input[1];

        List<int>[] graph = new List<int>[users+1];

        for (int i = 1; i <= users; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < con; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            graph[edge[0]].Add (edge[1]);
            graph[edge[1]].Add (edge[0]);
        }
        int result = 0;
        int summin = int.MaxValue;

        for (int i = 1; i <= users; i++)
        {
            int sum = 0;
            int[] dis = new int[users+1];
            Array.Fill(dis, -1);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(i);

            while (queue.Count>0)
            {
                int current = queue.Dequeue();
                foreach (int edge in graph[current])
                {
                    if (dis[edge] == -1)
                    {
                        dis[edge] = dis[current] + 1;
                        queue.Enqueue(edge);
                    }
                }
            }

            for (global::System.Int32 j = 0; j < dis.Length; j++)
            {
                if (dis[j]!=-1)
                {
                    sum += dis[j];
                }
            }

            if (summin > sum)
            {
                summin = sum;
                result = i;
            }

        }


        sw.WriteLine(result);
        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}

