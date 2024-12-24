using System.Collections.Generic;

class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            var stack = new Stack<(int index, int hieght)>();
            var result = new int[input];
            int[] tops = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int i = 0; i <tops.Length ; i++)
            {
                while (stack.Count > 0 && stack.Peek().hieght < tops[i])
                {
                    stack.Pop();
                }

                if (stack.Count==0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = stack.Peek().index+1;
                }

                stack.Push((i, tops[i]));
            }

           

            sw.WriteLine(string.Join(" ", result));

            sw.Flush(); sw.Close();
        }

    }
}
