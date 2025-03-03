
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int[] cn = Array.ConvertAll(Console.ReadLine().Split(" "), (Convert.ToInt32));
        int c = cn[0];
        int n = cn[1];


        List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
        for (int i = 0; i < n; i++)
        {
            int[] tp = Array.ConvertAll(Console.ReadLine().Split(" "), (Convert.ToInt32));
            int cost = tp[0];
            int people = tp[1];
            list.Add(new KeyValuePair<int, int>(cost, people));

        }

        int maxCost = 100000; 
        int[] dp = new int[maxCost + 1];
        Array.Fill(dp, -1);
        dp[0] = 0;

        foreach (var city in list)
        {
            for (int currentCost = 0; currentCost <= maxCost - city.Key; currentCost++)
            {
                if (dp[currentCost] != -1)
                {
                    int newCustomers = dp[currentCost] + city.Value;
                    int newCost = currentCost + city.Key;
                    if (dp[newCost] < newCustomers)
                    {
                        dp[newCost] = newCustomers;
                    }
                }
            }
        }

        int minCost = int.MaxValue;
        for (int cost = 0; cost <= maxCost; cost++)
        {
            if (dp[cost] >= c)
            {
                minCost = cost;
                break;
            }
        }
        sw.Write(minCost);
        sw.Flush(); sw.Close();
    }
}
