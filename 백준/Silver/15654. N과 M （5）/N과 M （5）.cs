class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        //int input = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int N = inputArr[0];
        int M = inputArr[1];
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        Array.Sort(nums);
        List<int> list = new List<int>();

        mn(0, 0);
        void mn(int start, int depth) 
        {
            if (depth==M)
            {
                sw.WriteLine(string.Join(" ", list));
                return;
            }

            for (global::System.Int32 i = 0; i < N; i++)
            {
                
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                    mn(nums[i], depth + 1);
                    list.RemoveAt(list.Count - 1);
                }
                
            }
        }


        
        sw.Flush(); sw.Close();
        Console.ReadLine();
       
    }
}