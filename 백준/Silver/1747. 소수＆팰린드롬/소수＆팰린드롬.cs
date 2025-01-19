
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int input = Convert.ToInt32(Console.ReadLine());
        int cur = input;
       
        while (true)
        {
            if (checkPrime(cur)&&checkReverse(cur))
            {
                break;
            }
            cur++;
        }
        
        bool checkPrime(int num) 
        {
            if (num < 2) return false;
            if (num == 2) return true;

            for (int i = 2; i*i <= num; i++)
            {
                if (cur % i == 0) 
                {
                    return false; 
                }
            }
            return true;
        }

        bool checkReverse(int num)
        {
            string str = cur.ToString();
            int len = str.Length;
            for (global::System.Int32 i = 0; i < len/2; i++)
            {
                if (str[i] != str[len-1-i])
                {
                    return false;
                }
            }
            return true;
        }


        sw.WriteLine(cur);
        sw.Flush(); sw.Close();


    }
}
