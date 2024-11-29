

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        
        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        

        for (int i = 0; i < input; i++)
        {
            bool error = false;
            int Rcheck = 0;

            LinkedList<int> deque = new LinkedList<int>();
            string com = Console.ReadLine();
            int arrLen = Convert.ToInt32(Console.ReadLine());
            string arr = Console.ReadLine();
            string result = arr.TrimStart('[').TrimEnd(']');
            int[] nums = new int[result.Length];
            if (result.Length>0)
            {
                nums = Array.ConvertAll(result.Split(","), Convert.ToInt32);
            }
            

            foreach (var item in nums)
            {
                deque.AddLast(item);
            }
            
            for (global::System.Int32 j = 0; j < com.Length; j++)
            {
                if (com[j]=='R')
                {
                    Rcheck++;
                }
                else
                {
                    if (deque.Count==0)
                    {
                        error =true;
                        break;
                    }
                    if (Rcheck % 2 == 0)
                    {
                        deque.RemoveFirst();
                    }
                    else
                    {
                        deque.RemoveLast();
                    }
                }
                
            }

            if (!error)
            {
                int[] resultarr = deque.ToArray();
                if (Rcheck % 2 == 1)
                {
                    Array.Reverse(resultarr);
                }
                sw.Write($"[");
                if (resultarr.Length>0)
                {
                    sw.Write($"{resultarr[0]}");
                }
                
                for (global::System.Int32 j = 1; j < resultarr.Length; j++)
                {
                    sw.Write($",{resultarr[j]}");
                }
                sw.WriteLine($"]");
            }
            else
            {
                sw.WriteLine($"error");
            }
        }
        

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}
