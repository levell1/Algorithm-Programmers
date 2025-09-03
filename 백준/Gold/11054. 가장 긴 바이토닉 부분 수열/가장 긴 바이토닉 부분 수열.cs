
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int n ;

    static void Main()
    {
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

        int[] left = new int [n];
        int[] right = new int [n];

        for (int i = 0; i < n; i++)
        {
            left[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[j] < arr[i])
                {
                    left[i] = Math.Max(left[i], left[j] + 1);
                }
            }

        }
        for (int i = n-1; i >= 0; i--)
        {
            right[i] = 1;
            for (int j = n-1; j > i; j--)
            {
                if (arr[j] < arr[i])
                {
                    right[i] = Math.Max(right[i], right[j] + 1);
                }
            }

        }

        int max = 0;
        for (int i = 0; i < n; i++)
        {
            max = Math.Max(max, left[i] + right[i] - 1);
        }
        sw.WriteLine(max);
        sw.Flush(); sw.Close();
    }
}
