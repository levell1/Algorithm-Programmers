
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var down = new PriorityQueue<int,int>();
        var up = new PriorityQueue<int,int>();

        var uplist = new List<int>();
        var downlist = new List<int>();

        for (int i = 0; i < input; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (up.Count == 0 || num < up.Peek())
            {
                up.Enqueue(num, -num);
            }
            else
            {
                down.Enqueue(num, num);
            }

            if (up.Count < down.Count)
            {
                int cur = down.Dequeue();
                up.Enqueue(cur, -cur);

            }
            else if (up.Count - 1 > down.Count)
            {
                int cur = up.Dequeue();
                down.Enqueue(cur, cur);
            }

            if (i % 2 == 0)
            {
                sw.WriteLine(up.Peek());
            }
            else
            {
                int mid = up.Peek()>down.Peek()? down.Peek():up.Peek();
                sw.WriteLine(mid);
            }

        }

        sw.Flush(); sw.Close();
    }
}
