
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var priQueue = new PriorityQueue<int,int>();


        for (int i = 0; i < input; i++)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            for (int j = 0; j < input; j++)
            {
                if (priQueue.Count>0&& priQueue.Peek() < nums[j])
                {
                    priQueue.Enqueue(nums[j], nums[j]);
                }
                else if (priQueue.Count==0)
                {
                    priQueue.Enqueue(nums[j], nums[j]);
                }
            }

            while (priQueue.Count > input) 
            {
                priQueue.Dequeue();
            };
        }

        sw.Write(priQueue.Dequeue());
        sw.Flush(); sw.Close();

    }
}
