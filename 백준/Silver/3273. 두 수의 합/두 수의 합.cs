
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[] arr;

    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = int.Parse(Console.ReadLine());

        Array.Sort(arr);

        int left = 0;
        int right = n-1;
        int sum = 0;
        int result = 0;

        while (left < right)
        {
            sum = arr[left] + arr[right];

            if (sum == x)
            {
                result++;
                left++;
                right--;
            }
            else if (sum < x) 
            {
                left++;
            }
            else
            {
                right--;
            }

        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

}

