class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int min = inputArr.Min();
        for (int i = 0; i < T; i++) 
        {
            if (min == inputArr[i]) 
            {
                sw.Write($"{i}");
                break;
            }
        }
        
        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}
