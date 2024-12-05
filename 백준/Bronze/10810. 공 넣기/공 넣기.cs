class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        
        int n = inputArr[0];
        int[] box = new int[n+1];
        int m = inputArr[1];

        for (int i = 0; i < m; i++)
        {
            int[] boxBall= Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int startBox = boxBall[0];
            int endBox = boxBall[1];
            int ballNum = boxBall[2];

            for (global::System.Int32 j = startBox; j <= endBox; j++)
            {
                box[j] = ballNum;
            }
        }
        for (int i = 1; i <= n; i++)
        {
            sw.Write($"{box[i]} ");
        }
        
        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}
