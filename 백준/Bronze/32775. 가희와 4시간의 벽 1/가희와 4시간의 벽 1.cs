
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            if (a <= b)
            {
                sw.WriteLine("high speed rail");
            }else
            {
                sw.WriteLine("flight");
            }

            sw.Flush(); sw.Close();
            Console.ReadLine();


        }
    }
}
