using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        bool[] visit = new bool[input[0]+1];

        List<int>[] graph = new List<int>[input[0] + 1];
        //그래프 초기화 필요.
        for (int i = 1; i <= input[0]; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < input[1]; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            graph[line[0]].Add(line[1]);
            graph[line[1]].Add(line[0]);
        }
        //정렬 
        for (int i = 1; i < graph.Length; i++)
        {
            graph[i].Sort();
        }

        DFS(input[2]);
        sb.AppendLine();
        Array.Clear(visit,0,visit.Length);

        BFS(input[2]);
        Console.WriteLine(sb.ToString());

        Console.ReadLine();

        void DFS(int a)
        {
            sb.Append($"{a} ");
            visit[a] = true;
            foreach (var next in graph[a])
            {
                if (!visit[next])
                {
                    DFS(next);
                }
            }
        }

        void BFS(int a)
        {
            Queue<int> queue = new Queue<int>();
            visit[a] = true;
            queue.Enqueue(a);
            sb.Append($"{a} ");

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                foreach (var next in graph[current])
                {
                    if (!visit[next])
                    {
                        visit[next] = true;
                        queue.Enqueue(next);
                        sb.Append($"{next} ");
                    }
                }
            }
        }
    }
}