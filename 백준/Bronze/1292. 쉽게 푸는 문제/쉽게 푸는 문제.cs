class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {

        int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = ab[0];
        int b = ab[1];

        int[] arr = new int[b + 1];
        int change = 1;
        int count = 1;
        for (int i = 1; i < b+1; i++)
        {
            arr[i] = count;
            change--;
            if (change==0)
            {
                count++;
                change = count;
            }
        }

        int result = 0;
        for (int i = a; i <= b; i++)
        {
            result += arr[i];
        }


        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

    
}
