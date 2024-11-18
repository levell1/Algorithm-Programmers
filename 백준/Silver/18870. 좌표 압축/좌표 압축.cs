using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = Convert.ToInt32(Console.ReadLine());
        int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        Dictionary <int,int> a = new Dictionary<int,int>();


        int[] sorted = x.Distinct().ToArray();
        Array.Sort(sorted);

        int count = 0;
        foreach (var i in sorted)
        {
            a[i] = count;
            count++;
        }

        for (int i = 0; i < x.Length; i++)
        {
            sb.Append($"{a[x[i]]} ");
        }

        Console.WriteLine( sb.ToString() );
    }
}
