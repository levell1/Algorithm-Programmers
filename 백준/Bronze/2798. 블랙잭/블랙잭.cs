using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] nm = input.Split(' ');

        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        string inputnum = Console.ReadLine();
        string[] nums = inputnum.Split(' ');
        int[] num = new int[n];
        for (int i = 0; i < nums.Length; i++)
        {
            num[i] = int.Parse(nums[i]);
        }

        int add = 0;
        int result = 0;
        for (int i = 0; i < n-2; i++)
        {
            add += num[i];
            for (int j = i+1; j < n; j++)
            {
                add += num[j];
                for (int k = j+1; k < n; k++)
                {
                    add += num[k];
                    if (add <=m&&add>result)
                    {
                        result = add;
                    }
                    add -= num[k];
                }
                add -= num[j];
            }
            add -= num[i];
        }


        Console.WriteLine(result);
        Console.ReadLine();
    }
}
