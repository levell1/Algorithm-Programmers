using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int[,] graph = new int[input[0]+1,input[0]+1];
        bool[] visit = new bool[input[0]+1];
        
        for (int i = 0; i < input[1]; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            graph[line[0], line[1]] = 1;
            graph[line[1], line[0]] = 1;
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
            for (int i = 0; i <= input[0]; i++)
            {
                if (graph[a, i] == 1 && !visit[i])
                {
                    DFS(i);
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

                for (int i = 0; i <= input[0]; i++)
                {
                    if (graph[current, i] == 1 && !visit[i])
                    {
                        visit[i] = true;
                        queue.Enqueue(i);
                        sb.Append($"{i} ");
                    }
                }
            }
        }

    }
}