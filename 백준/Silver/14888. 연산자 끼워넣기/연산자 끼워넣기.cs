
using System.Text;

class Program
{
    static int n;
    static int[] nums;
    static int[] oper = new int[4];
    static List<int> result = new List<int>();
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        n = Convert.ToInt32(Console.ReadLine());
        nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        oper = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        DFS(1, nums[0]);
        sw.WriteLine(result.Max());
        sw.WriteLine(result.Min());
        sw.Flush(); sw.Close();

    }

    static void DFS(int depth, int cur) 
    {
        if (depth ==n)
        {
            result.Add(cur);
            return;
        }
        for (int i = 0; i < 4; i++)
        {
            if (oper[i] > 0)
            {
                oper[i]--;

                int next = cur;
                int num = nums[depth];

                if (i == 0) next += num;
                else if (i == 1) next -= num;
                else if (i == 2) next *= num;
                else if (i == 3)
                {
                    if (next < 0)
                        next = -(-next / num); 
                    else
                        next /= num;
                }

                DFS(depth + 1, next);
                oper[i]++; 
            }
        }
    }


}