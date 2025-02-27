class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int[] n = Array.ConvertAll(Console.ReadLine().Split(" "), (Convert.ToInt32));
        int x = n[0]*n[1];

        int[] p = Array.ConvertAll(Console.ReadLine().Split(" "), (Convert.ToInt32));

        foreach (int i in p) 
        {
            sw.Write($"{i-x} ");
        }

        sw.Flush(); sw.Close();
    }
}
