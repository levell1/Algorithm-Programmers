
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int start = inputArr[0];
        int end = inputArr[1];

        sw.Write(bfs(start));
        sw.Flush(); sw.Close();
        Console.ReadLine();
      
        int bfs(int start)
        {
            Queue<(long num,int count)> queue = new Queue<(long, int)>();
            queue.Enqueue((start,1));
            

            while (queue.Count > 0)
            {
                (long curnum, int curcount)   = queue.Dequeue();
                
                if (curnum == end)
                {
                    return curcount;
                }
                long case1 = curnum * 2;
                long case2 = curnum * 10 + 1;

                if (case1 <= end)
                {
                    queue.Enqueue((case1, curcount + 1));
                }

                if (case2 <= end)
                {
                    queue.Enqueue((case2, curcount + 1));
                }
            }
            return -1;
        }
    }
}