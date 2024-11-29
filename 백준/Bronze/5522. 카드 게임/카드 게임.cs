
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            sum += input;
        }
        sw.Write(sum);

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}