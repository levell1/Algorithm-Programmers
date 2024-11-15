using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int n = input[0];
        int r = input[1];
        int c = input[2];
        int size = Convert.ToInt32(Math.Pow(2, n));
        int count = 0;


        findrc(0, 0, size);

        void findrc( int x, int y, int n)
        {
            if (n==1)
            {
                sb.AppendLine((count).ToString());
                return;
            }
            n /= 2;

            if (c < x + n && r < y + n)
            {
                findrc(x, y, n);
            }
            else if (c >= x + n && r < y + n)
            {
                count += n * n;
                findrc(x + n, y, n);
            }
            else if (c < x + n && r >= y + n)
            {
                count += (n * n) * 2;
                findrc(x, y + n, n);
            }
            else
            {
                count += (n * n) * 3;
                findrc(x + n, y + n, n);
            }

        }

        Console.WriteLine(sb.ToString());
    }
}
