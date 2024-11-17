using System.Security;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int woodCount = input[0];
        int need = input[1];

        int[] woods = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int left = 0;
        int right = woods.Max();
        long sum = 0;
        int mid = 0;
        int result = 0;
        while (left <= right)
        {
            mid = (left + right)/2;
            sum = 0;
            for (int i = 0; i < woods.Length; i++)
            {
                if (woods[i]>mid)
                {
                    sum += woods[i] - mid;
                }
                
            }

            if (sum >= need)
            {
                result = mid;
                left = mid + 1;
                
            }
            else  
            {
                right = mid - 1;
            }

        }

        Console.WriteLine(result);
    }
}
