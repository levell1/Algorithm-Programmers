
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = input[0];
            int b = input[1];
            int cur = 1 ;
            for (int j = 0; j < b; j++)
            {
                cur = cur * a % 10;
            }
            if (cur ==0)
            {
                cur = 10;
            }
            sw.WriteLine(cur);
        }

            

        sw.Flush(); sw.Close();
    }

}
