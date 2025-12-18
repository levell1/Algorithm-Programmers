
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int n = nm[0];
        int m = nm[1];

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = i+1;
        }

        for (int i = 0; i < m; i++)
        {
            int[] change = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int first = change[0]-1;
            int second = change[1]-1;

            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;

        }


        sw.WriteLine(string.Join(' ',arr));
        

        sw.Flush(); sw.Close();
    }

}
