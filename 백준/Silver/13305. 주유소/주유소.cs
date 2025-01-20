
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);


        int count = Convert.ToInt32(Console.ReadLine());



        int[] len = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] cost = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int sum = 0;
        int mincost = cost[0];
        for (int i = 0; i < count-1; i++)
        {
            if (mincost > cost[i])
            {
                mincost = cost[i];
            }
            sum += mincost * len[i];
        }
        

        sw.WriteLine($"{sum}");
        sw.Flush(); sw.Close();

    }
}
