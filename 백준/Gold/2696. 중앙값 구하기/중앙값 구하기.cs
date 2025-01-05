
using System.Reflection;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var down = new PriorityQueue<int,int>();
        var up = new PriorityQueue<int,int>();
        var result = new List<int>();

        for (int i = 0; i < input; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            double x = (num - 1) / 10;
            int re = (int)Math.Truncate(x) +1;
            int ten = 0;
            for (global::System.Int32 j = 0; j < re; j++)
            {
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                for (global::System.Int32 k = 0; k < nums.Length; k++)
                {

                    if (up.Count == 0 || nums[k] <= up.Peek())
                    {
                        up.Enqueue(nums[k], -nums[k]);
                    }
                    else
                    {
                        down.Enqueue(nums[k], nums[k]);
                    }

                    if (up.Count<down.Count)
                    {
                        int cur = down.Dequeue();
                        up.Enqueue(cur, -cur);
                        
                    }else if (up.Count-1 > down.Count)
                    {
                        int cur = up.Dequeue();
                        down.Enqueue(cur, cur);
                    }

                    if ((ten*10+k) % 2 == 0)
                    {
                        result.Add(up.Peek());
                    }
                }
                ten++;
            }
            sw.WriteLine(result.Count);
            sw.WriteLine(string.Join(" ",result));
            up.Clear();
            down.Clear();
            result.Clear();
        }

        sw.Flush(); sw.Close();

    }
}
