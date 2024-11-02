using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {
        
        int input = Convert.ToInt32( Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int[,] graph = new int[input+1,input+1];
        bool[] visited = new bool[input+1];
        int sum = 0;
        int con = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < con; i++)
        {
            int[] a = Array.ConvertAll( Console.ReadLine().Split(' '),Convert.ToInt32);
            graph[a[0],a[1]] = 1;
            graph[a[1],a[0]] = 1;
        }

        dfs(1);

        void dfs(int a) 
        {
            visited[a] = true;
            sum++;
            for (int i = 1; i <= input; i++)
            {
                if (graph[a, i] == 1 && !visited[i])
                {
                    dfs(i);
                }
            }
        }

        Console.WriteLine(sum-1);
        Console.ReadLine();
    }
}


