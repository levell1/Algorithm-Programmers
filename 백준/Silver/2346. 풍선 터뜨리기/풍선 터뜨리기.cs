class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            var deque = new LinkedList<(int index,int num)>();
            

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int i = 1; i <= input; i++)
            {
                deque.AddLast((i,nums[i-1]));
            }
            //sw.Write(string.Join(" ", curindex));

            for (int i = 0; i < input; i++)
            {
                var (curindex,move) = deque.First();
                deque.RemoveFirst();
                sw.Write($"{curindex} ");
                if (deque.Count == 0) 
                {
                    break;
                }
                if (move > 0)
                {
                    while (move-- > 1) 
                    {
                        deque.AddLast(deque.First());
                        deque.RemoveFirst();
                    }
                }
                else
                {
                    while (move++ < 0)
                    {
                        deque.AddFirst(deque.Last());
                        deque.RemoveLast();
                    }
                }
                
            }
            sw.Flush(); sw.Close();
        }
    }
}
