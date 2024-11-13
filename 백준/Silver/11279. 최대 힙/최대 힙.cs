using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = Convert.ToInt32(Console.ReadLine());
        var heap = new PriorityQueue<int, int>();

        for (int i = 0; i < input; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 0)
            {
                if (heap.Count > 0)
                {
                    sb.AppendLine(heap.Dequeue().ToString());
                }
                else
                {
                    sb.AppendLine("0");
                }
            }
            else
            {
                heap.Enqueue(x, -x);
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
