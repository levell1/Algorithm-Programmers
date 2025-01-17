using System.ComponentModel;

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
        bool[] visited = new bool[N];
        
        mn(0,0);
        void mn(int start,int depth) 
        {
            if (depth==M)
            {
                sw.WriteLine(string.Join(" ", list));
                return;
            }
            int pre = 0;

            for (global::System.Int32 i = start; i < N; i++)
            {

                if (pre != nums[i])
                {
                    list.Add(nums[i]);
                    pre = nums[i];
                    mn(i,depth + 1);
                    list.RemoveAt(list.Count - 1);
                }
                
            }
        }


        
        sw.Flush(); sw.Close();
        Console.ReadLine();
       
    }
}