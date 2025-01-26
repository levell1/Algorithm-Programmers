
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int n = Convert.ToInt32(Console.ReadLine());
      
        
        var ST = new (int,int)[n];
        var list = new List<(int start, int end)>();

        for (int i = 0; i < n; i++)
        {
            int[] st = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            list.Add ((st[0], st[1]));
        }

        list.Sort((a, b) => a.start.CompareTo(b.start));
        var pq = new PriorityQueue<int, int>();

        foreach (var lecture in list)
        {
            if (pq.Count>0 && pq.Peek() <= lecture.start)
            {
                pq.Dequeue();
            }

            pq.Enqueue(lecture.end, lecture.end);
        }

        sw.WriteLine(pq.Count);
        sw.Flush(); sw.Close();

    }
}
