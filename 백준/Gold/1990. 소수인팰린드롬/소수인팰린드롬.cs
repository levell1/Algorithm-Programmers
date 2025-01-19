
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int cur = inputArr[0];
        int end = inputArr[1];
       
        while (cur<=end)
        {
            if (checkReverse(cur))
            {
                if (checkPrime(cur))
                {
                    sw.WriteLine(cur);
                }
                
            }
            cur++;
        }
        
        bool checkPrime(int num) 
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i*i <= num; i+=2)
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
            for (int i = 0; i < len/2; i++)
            {
                if (str[i] != str[len-1-i])
                {
                    return false;
                }
            }
            return true;
        }


        sw.WriteLine(-1);
        sw.Flush(); sw.Close();


    }
}
