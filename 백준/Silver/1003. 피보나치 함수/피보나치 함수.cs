using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {
        
        int input = Convert.ToInt32( Console.ReadLine());

        int[] dp0 = new int[41];
        int[] dp1 = new int[41];

        dp0[0] = 1;
        dp0[1] = 0;

        dp1[0] = 0;
        dp1[1] = 1;


        for (int i = 2; i < 41; i++)
        {
            dp0[i] = dp0[i - 2] + dp0[i - 1];
            dp1[i] = dp1[i - 2] + dp1[i - 1];
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            sb.Append(dp0[num]);
            sb.Append(" ");
            sb.AppendLine(dp1[num].ToString());
        }

        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}


