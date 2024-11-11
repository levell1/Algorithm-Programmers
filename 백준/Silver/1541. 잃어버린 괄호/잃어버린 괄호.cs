using System;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        string[] input = Console.ReadLine().Split('-');

        int sum = sumnums(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            sum -= sumnums(input[i]);
        }

        Console.WriteLine(sum);
        Console.ReadLine();

        int sumnums(string x) 
        {
            int[] nums = Array.ConvertAll(x.Split('+'), Convert.ToInt32);
            int sumnum = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                sumnum += nums[j];
            }
            return sumnum;
        }
    }
}