
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int input = Convert.ToInt32(Console.ReadLine());

        int cur = input;

        for (int i = 2; i * i <= cur; i++) 
        {
            while (cur % i == 0) 
            {
                sw.WriteLine(i);
                cur /= i; 
            }
        }

        if (cur > 1) 
        {
            sw.WriteLine(cur);
        }

        sw.Flush(); sw.Close();

    }
}
