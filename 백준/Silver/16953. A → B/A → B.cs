
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int start = inputArr[0];
        int end = inputArr[1];

        bool[] visited = new bool[end + 1];

        int min = int.MaxValue;

        bfs(start);
        if (min == int.MaxValue)
        {
            sw.Write(-1);
        }
        else
        {
            sw.Write(min);
        }
        

        sw.Flush(); sw.Close();
        Console.ReadLine();
      
        void bfs(int start)
        {
            visited[start] = true;
            Queue<(long num,int count)> queue = new Queue<(long, int)>();
            queue.Enqueue((start,1));
            

            while (queue.Count > 0)
            {

                (long curnum, int curcount)   = queue.Dequeue();
                
                if (curnum == end)
                {
                    min = curcount;
                    return;
                }
                long case1 = curnum * 2;
                long case2 = curnum * 10 + 1;

                if (case1 <= end)
                {
                    if (!visited[case1])
                    {
                        visited[case1] = true;
                        queue.Enqueue((case1, curcount + 1));
                    }
                }

                if (case2 <= end)
                {
                    if (!visited[case2])
                    {
                        visited[case2] = true;
                        queue.Enqueue((case2, curcount + 1));
                    }
                }
            }
        }
    }
}