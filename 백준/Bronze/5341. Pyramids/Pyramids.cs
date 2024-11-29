
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        while (true) {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input==0)
            {
                break;
            }
            sw.WriteLine($"{fac(input)}");
        }
        

        int fac(int x) 
        {
            int sum = 0;
            for (global::System.Int32 i = 1; i <= x; i++)
            {
                sum += i;
            }
            return sum;
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}