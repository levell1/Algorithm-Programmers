

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int n, c;
    static int[] pos;

    static void Main()
    {

        int[] nc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = nc[0];
        c = nc[1];
        pos = new int[n];

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            pos[i] = x;
        }
        Array.Sort(pos);

        int low = 1;
        int high = pos[n - 1] - pos[0];
        int result = 0;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (Check(mid))
            {
                result = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }


    static bool Check(int dist)
    {
        int count = 1;
        int last = pos[0];

        for (int i = 1; i < n; i++)
        {
            if (pos[i] - last >= dist)
            {
                count++;
                last = pos[i];
                if (count >= c)
                {
                    return true;
                }
            }
        }
        return count >= c;
    }

}