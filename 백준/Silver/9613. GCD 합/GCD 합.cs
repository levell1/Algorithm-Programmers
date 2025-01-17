
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
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int numsCount = inputArr[0];
            long sum = 0;
            for (global::System.Int32 j = 1; j < numsCount; j++)
            {
                for (global::System.Int32 k = j+1; k <= numsCount; k++)
                {
                    sum += gcd(inputArr[j], inputArr[k]);
                }
            }
            sw.WriteLine(sum);
        }

        sw.Flush(); sw.Close();

        int gcd(int a , int b) 
        {
            int result = 0;
            int temp = 0;
            while (a%b>0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            
            return b;
        }

    }
}
