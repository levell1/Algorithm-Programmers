using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        Dictionary<string,int> dic = new Dictionary<string,int>();

        for (int i = 0; i < input; i++)
        {
            int sum = 1;
            int testcase = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < testcase; j++)
            {
                string[] clothes = Console.ReadLine().Split(' ');
                if (dic.ContainsKey(clothes[1]))
                {
                    dic[clothes[1]]++;
                }
                else
                {
                    dic.Add(clothes[1], 2);
                }
            }
            foreach (var item in dic)
            {
                sum *= item.Value;
            }
            sum--;
            sb.AppendLine(sum.ToString());
            dic.Clear();
        }

        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}