using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);
        int upper = (int)Math.Round(testcase * 0.15, MidpointRounding.AwayFromZero);

        if (testcase == 0)
        {
            Console.WriteLine(0);
            return;
        }


        List<int> diffs = new List<int>();

        for (int i = 0; i < testcase; i++)
        {
            int level = Convert.ToInt32( Console.ReadLine());
            diffs.Add(level);
        }
        diffs.Sort();

        List<int> trimmed = diffs.Skip(upper).Take(testcase - 2 * upper).ToList(); // upper 만큼 건너뛰고 총길이- 2*upper 만큼만 출력 -> 뒤에 upper 만큼 제거

        Console.WriteLine(Math.Round(trimmed.Average(), MidpointRounding.AwayFromZero));
        Console.ReadLine();
        
    }

}
