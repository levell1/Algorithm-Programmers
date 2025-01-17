
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            long num = long.Parse( Console.ReadLine());
            long cur = num;
            bool check = false;

            while (!check) 
            { 
                if (cur<=2)
                {
                    cur = 2;
                    break;
                }
                check = prime(cur);
                if (check==true)
                {
                    break;
                }
                cur++;
            }


            sw.WriteLine(cur);
        }

        sw.Flush(); sw.Close();

        bool prime(long cur)
        {
            for (long i = 2; i * i <= cur; i ++)
            {
                if (cur % i == 0) return false;
            }
            return true;
        }

    }
}
