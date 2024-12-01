class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int T = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        while (T-- > 0)
        { 
            string[] inputArr = (Console.ReadLine().Split(" "));
            int org = int.Parse(inputArr[0]);
            int goal = int.Parse(inputArr[1]);

            string result = BFS(org, goal);
            sw.WriteLine($"{result}");
        }
            

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }

    static string BFS(int orgin, int goalnum)
    {
        bool[] visited = new bool[10000];
        Queue<(int, string)> queue = new Queue<(int, string)>();
        queue.Enqueue((orgin, ""));

        while (queue.Count>0) 
        {
            (int curnum, string com) = queue.Dequeue();

            if (curnum ==goalnum)
            {
                return com;
            }

            int d = (curnum * 2) % 10000;
            if (!visited[d])
            {
                visited[d] = true;
                queue.Enqueue((d, com + "D"));
            }

            int s = (curnum == 0) ? 9999 : curnum - 1;
            if (!visited[s])
            {
                visited[s] = true;
                queue.Enqueue((s, com + "S"));
            }

            int l = (curnum % 1000) * 10 + (curnum / 1000);
            if (!visited[l])
            {
                visited[l] = true;
                queue.Enqueue((l, com + "L"));
            }

            int r = (curnum % 10) * 1000 + (curnum / 10);
            if (!visited[r])
            {
                visited[r] = true;
                queue.Enqueue((r, com + "R"));
            }

        }
        return "";
    }
}
