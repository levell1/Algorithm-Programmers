
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int result;
    static int n;
    static int m;
    static int[] arr;
    static List<int> list;
    static void Main()
    {

        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = nm[0];
        m = nm[1];

        arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(arr);

        list = new List<int>();

        NM6(-1, 0);

        sw.Flush(); sw.Close();
    }

    static void NM6(int start,int depth) 
    {
        if (depth >= m)
        {
            sw.WriteLine(string.Join(" ",list));
            return;
        }

        for (int i = start+1; i < n; i++)
        {
            list.Add(arr[i]);
            NM6(i, depth + 1);
            list.RemoveAt(list.Count - 1);
        }
    }
}

