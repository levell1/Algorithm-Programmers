using System.Collections.Generic;

class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            var stack = new Stack<int>();
            var result = new int[input];
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                int[] building = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

                if (stack.Count==0)
                {
                    stack.Push((building[1]));
                    continue;
                }

                if (stack.Peek() < building[1])
                {
                    stack.Push(( building[1]));
                }else if (stack.Peek() > building[1])
                {
                    while (stack.Peek() > building[1])
                    {
                        stack.Pop();
                        sum++;
                        if (stack.Count == 0) 
                        {
                            break;
                        }
                    }
                    if (stack.Count==0)
                    {
                        stack.Push((building[1]));
                    }else if (stack.Peek() < building[1])
                    {
                        stack.Push((building[1]));
                    }
                    
                }
            }

            int count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                if (stack.Pop() != 0) 
                {
                    sum++;
                }
            }



            sw.WriteLine(sum);

            sw.Flush(); sw.Close();
        }

    }
}
