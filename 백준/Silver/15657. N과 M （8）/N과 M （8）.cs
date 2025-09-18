
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int N,M;
    static List<int> list;
    static int[] arr;
    static void Main()
    {

        int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        N = NM[0];
        M = NM[1];

        arr = new int[N];

        arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(arr);

        list = new List<int>();

        MN8(0, 0);


        sw.Flush(); sw.Close();
    }

    

    static void MN8(int start, int depth) 
    {
        if (depth==M)
        {
            sw.WriteLine(string.Join(" ", list));
            return;
        }

        for (int i = start; i < N; i++)
        {
            list.Add(arr[i]);
            MN8(i, depth + 1);
            list.RemoveAt(list.Count - 1);
        }
    }
    
}

