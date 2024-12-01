class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int num = 1;
        for (int i = input; i > 0; i--)
        {
            num *= i;
        }

        sw.Write(num);

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}
