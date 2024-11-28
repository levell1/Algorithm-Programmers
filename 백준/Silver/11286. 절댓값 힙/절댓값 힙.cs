
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());

        //int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        PriorityQueue<int,int> heap= new PriorityQueue<int,int>();

        for (int i = 0; i < input; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                if (heap.Count>0)
                {
                    sw.WriteLine(heap.Dequeue());
                }
                else
                {
                    sw.WriteLine(0);
                }


            }
            else
            {
                int add = 1;
                if (num<0)
                {
                    add = -1;
                }
                heap.Enqueue(num,(Math.Abs(num)*3)+add);

            }
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}