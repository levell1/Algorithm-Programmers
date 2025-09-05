
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int count;


    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
        int n = input[0];
        int s = input[1];

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

        int left = 0;
        int right = 0;

        count = n+1;

        int sum =arr[0];
        while (true)
        {
            //Console.WriteLine($"{left} {right} {sum}");

            if (sum >= s)
            {
                count = Math.Min(count, (right - left + 1));
                sum -= arr[left];
                left++;
            }
            else if (right == n-1) 
            {
                break;
            }
            else
            {
                right++;
                sum += arr[right];
            }
            
        }

        if (count==n+1)
        {
            count = 0;
        }

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

    
}
