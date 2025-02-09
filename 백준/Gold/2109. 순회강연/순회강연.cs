class Program
{
    static void Main()
    {

        int num = int.Parse(Console.ReadLine());

        (int p, int w)[] arr = new (int p, int w)[num];

        for (int i = 0; i < num; i++)
        {
            int[] index = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            arr[i] = (index[0], index[1]);
        }

        Array.Sort(arr, (x, y) => y.p.CompareTo(x.p));

        int[] check = new int[10001];

        for (int i = 0; i < num; i++)
        {
            for (int j = arr[i].w; j > 0; j--)
            {
                if (check[j] != 0)
                {
                    continue;
                }
                else
                {
                    check[j] = arr[i].p;
                    break;
                }
            }
        }

        Console.WriteLine(check.Sum());

    }
}
