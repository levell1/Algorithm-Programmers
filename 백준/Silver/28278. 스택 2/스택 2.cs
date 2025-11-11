
using System.Runtime.Intrinsics.Arm;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static Stack<int> stack;
    static void Main()
    {
        stack = new Stack<int>();
        int n = int.Parse( Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] com = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (com[0] ==1)
            {
                stack.Push(com[1]);
            }
            else
            {
                Commend(com[0]);
            }
        }



        sw.Flush(); sw.Close();
    }


    static void Commend(int c) 
    {
        if (c == 2)
        {
            if (stack.Count>0)
            {
                sw.WriteLine(stack.Pop());
            }
            else
            {
                sw.WriteLine(-1);
            }
        }
        if (c == 3)
        {
            sw.WriteLine(stack.Count);
        }
        if (c == 4)
        {
            if (stack.Count > 0)
            {
                sw.WriteLine(0);
            }
            else
            {
                sw.WriteLine(1);
            }
        }
        if (c == 5)
        {
            if (stack.Count > 0)
            {
                sw.WriteLine(stack.Peek());
            }
            else
            {
                sw.WriteLine(-1);
            }
        }

    }

}
