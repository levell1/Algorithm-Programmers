using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);

        List<int> nums = new List<int>();
        for (int i = 0; i < testcase; i++)
        {
            string inputnum = Console.ReadLine();
            nums.Add(Convert.ToInt32(inputnum));
        }
        nums.Sort();
        int[] check = new int[nums.Count];

        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        int max = 0;
        int mode = 0;
        foreach (var num in nums)
        {
            if (frequency[num]>max)
            {
                mode = num;
                max = frequency[num];
            }
        }
        List<int> modelist = new List<int>();
        foreach (var num in nums)
        {
            if (frequency[num] == max)
            {
                modelist.Add(num);
            }
        }
        modelist = modelist.Distinct().ToList();
        if (modelist.Count>1)
        {
            modelist.Sort();
            mode = modelist[1];
        }

        int avg = (int)Math.Round(nums.Average(), MidpointRounding.AwayFromZero);
        Console.WriteLine(avg);
        Console.WriteLine(nums[testcase / 2]);
        Console.WriteLine(mode);
        Console.WriteLine(nums[testcase - 1] - nums[0]);


        Console.ReadLine();
    }
}