class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);


        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int n = inputArr[0];
        int k = inputArr[1];

        bool[] checkPrime = new bool[n+1];

        int count = 0;
        int result = 0;
        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; i*j <= n; j++)
            {
                int cur = i * j;
                if (checkPrime[cur])
                {
                    continue;
                }

                count++;
                checkPrime[cur] = true;
                if (count == k)
                {
                    result = cur;
                    break;
                }
            }
            if (result != 0) { break; }
        }


        sw.WriteLine(result);
        sw.Flush(); sw.Close();


    }
}
