
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int input = Convert.ToInt32(Console.ReadLine());
        for (int z = 0; z < input; z++)
        {
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int num1 = inputArr[0];
            int num2 = inputArr[1];
            int max = 0;
            int min = 0;

            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    max = i;
                }
            }
            min = num1 * num2 / max;

            sw.WriteLine(min);
        }
        
        sw.Flush(); sw.Close();

    }
}
