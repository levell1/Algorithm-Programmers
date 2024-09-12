using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string inputnums = Console.ReadLine();
        string[] a = inputnums.Split(' ');
        int[] nums = new int[a.Length];
        int count = a.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(a[i]);
            if (nums[i] == 1)
            {
                count--;
            }
            for (int j = nums[i]-1; j > 1; j--)
            {
                if (nums[i] % j == 0)
                {
                    count--;
                    break;
                }
            }
        }

        Console.WriteLine(count);

        Console.ReadLine();
    }
}
