class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int n = Convert.ToInt32(Console.ReadLine());
        int card = 0;
        int result = 0;

        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();

        for (int i = 0; i < n; i++)
        {
            card = Convert.ToInt32(Console.ReadLine());
            queue.Enqueue(card, card);
        }

        while (queue.Count>1)
        {
            int first = queue.Dequeue();
            int second = queue.Dequeue();
            int sum = first + second;
            queue.Enqueue(sum, sum);
            result += sum;
        }

        sw.WriteLine(result);

        sw.Flush(); sw.Close();

    }
}
