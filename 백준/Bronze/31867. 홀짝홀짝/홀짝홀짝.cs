
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            string num = Console.ReadLine();
            int even = 0;
            int odd = 0;
            foreach (var ch in num) 
            {
                int number = ch - '0';
                if (number % 2 == 0) 
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            int result = -1;

            if (even > odd)
            {
                result = 0;
            }else if (even<odd)
            {
                result = 1;
            }

            sw.WriteLine(result);
            sw.Flush(); sw.Close();
        }

    }
}
