using System;
using System.Text;
using System.Threading;



class Program
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        bool[,] visit;
        int[,] field;
        int[] nums;
        for (int n = 0; n < input; n++)
        {
            nums = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            visit = new bool[nums[0], nums[1]];
            field = new int[nums[0], nums[1]];

            for (int i = 0; i < nums[2]; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                field[xy[0], xy[1]] = 1;
            }
            int count = 0;

            for (int i = 0; i < nums[0]; i++)
            {
                for (int j = 0; j < nums[1]; j++)
                {
                    if(field[i, j] == 1&& visit[i, j]==false)
                    {
                        dfs(i, j);
                        count++;
                    }
                }
            }
            sb.AppendLine(count.ToString());
        }
        Console.WriteLine(sb.ToString());
        Console.ReadLine();

        void dfs(int a,int b)
        {
            visit[a,b] = true;
            if (a - 1 >= 0&& visit[a - 1, b] ==false)
            {
                if (field[a - 1, b] == 1)
                {
                    dfs(a - 1, b);
                }
            }
            if (a + 1 < nums[0] && visit[a + 1, b] == false)
            {
                if (field[a + 1, b] == 1)
                {
                    dfs(a + 1, b);
                }
            }
            if (b-1>=0 && visit[a, b - 1] == false)
            {
                if (field[a, b - 1] == 1)
                {
                    dfs(a, b - 1);
                }
            }
            if (b + 1 < nums[1] && visit[a, b + 1] == false)
            {
                if (field[a, b + 1] == 1)
                {
                    dfs(a, b + 1);
                }
            }
        }
    }
}