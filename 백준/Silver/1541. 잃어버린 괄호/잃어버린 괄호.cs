using System;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        string[] input = Console.ReadLine().Split('-');
        
        int[] nums = Array.ConvertAll(input[0].Split('+'), Convert.ToInt32);
        int sum = sumnums(nums);

        for (int i = 1; i < input.Length; i++)
        {
            nums = Array.ConvertAll(input[i].Split('+'), Convert.ToInt32);
            sum -= sumnums(nums);
        }

        Console.WriteLine(sum);
        Console.ReadLine();

        int sumnums(int[] x) 
        {
            int sumsum = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                sumsum += x[j];
            }
            return sumsum;
        }
    }
}