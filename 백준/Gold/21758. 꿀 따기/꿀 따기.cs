
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int n = Convert.ToInt32(Console.ReadLine());
        int[] honey = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] sum = new int[n];
        sum[0] = honey[0];

        for (int i = 1; i < n; i++)
        {
            sum[i] = sum[i - 1] + honey[i];
        }

        int max = 0;

        //벌통 센터
        int maxhoney = (sum[n - 1]) - honey[n - 1] - honey[0]+honey[(n-1)/2];
        max = Math.Max(maxhoney, max);

        //벌통 오른쪽
        for (int i = 1; i < n-1; i++)
        {
            maxhoney = (sum[n - 1] - honey[0] - honey[i]) + (sum[n - 1] - sum[i]);
            max = Math.Max(maxhoney, max);
        }

        //벌통 왼쪽
        for (int i = 1; i < n-1; i++)
        {
            maxhoney = (sum[n - 1] - honey[n-1] - honey[i]) + (sum[i] - honey[i]);
            max = Math.Max(maxhoney, max);
        }

        sw.WriteLine(max);
        sw.Flush(); sw.Close();

    }
}
