
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        
        int[] nk = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int n = nk[0];
        int k = nk[1];

        List<(int w, int v)> jewel = new List<(int w, int v)>();
        int[] bag = new int[k];

        for (int i = 0; i < n; i++)
        {
            int[] mv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            jewel.Add((mv[0], mv[1]));
        }

        for (int i = 0; i < k; i++)
        {
            int c = int.Parse(Console.ReadLine());
            bag[i] = c;
        }

        jewel.Sort((a, b) => a.w.CompareTo(b.w));
        Array.Sort(bag);

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        long answer = 0;
        int idx = 0;

        foreach (int b in bag)
        {
            while (idx<n && jewel[idx].w<=b)
            {
                pq.Enqueue(jewel[idx].v, -jewel[idx].v);
                idx++;
            }

            if (pq.Count>0)
            {
                answer += pq.Dequeue();
            }
        }
        sw.Write(answer);
        sw.Flush(); sw.Close();
    }

}


