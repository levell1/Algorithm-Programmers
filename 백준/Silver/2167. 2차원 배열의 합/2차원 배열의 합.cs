
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int n, m;
    static int[,] arr;


    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        n = nm[0];
        m = nm[1];

        arr = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = line[j];
            }
        }

        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            int[] ijxy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int result = SumIJXY(ijxy[0]-1, ijxy[1]-1, ijxy[2]-1, ijxy[3]-1);

            sw.WriteLine(result);
        }


        
        sw.Flush(); sw.Close();
    }


    static int SumIJXY(int si,int sj, int ex, int ey) 
    {
        int sum = 0;
        for (int i = si; i <= ex; i++)
        {
            for (int j = sj; j <= ey; j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }

}
