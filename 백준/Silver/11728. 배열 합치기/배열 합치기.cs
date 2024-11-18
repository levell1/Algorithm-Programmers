
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int NLen = input[0];
        int MLen = input[1];
        int[] N = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int[] M = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int[] merge = new int[NLen + MLen];
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < NLen && j < MLen)
        {
            if (N[i] < M[j])
            {
                merge[k++] = N[i++];
            }
            else
            {
                merge[k++] = M[j++];
            }
        }

        while (i < NLen) 
        {
            merge[k++] = N[i++];
        }
        while (j < MLen)
        {
            merge[k++] = M[j++];
        }

        foreach (var item in merge)
        {
            sw.Write($"{item} ");
            
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();

    }
}
