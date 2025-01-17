using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = Convert.ToInt32(Console.ReadLine());
        var minHeap = new PriorityQueue<int, int>();

        for (int i = 0; i < input; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 0)
            {
                if (minHeap.Count > 0)
                {
                    sb.AppendLine(minHeap.Dequeue().ToString());
                }
                else
                {
                    sb.AppendLine("0");
                }
            }
            else
            {
                minHeap.Enqueue(x, x);
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
