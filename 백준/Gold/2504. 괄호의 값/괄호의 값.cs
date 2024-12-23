using System.Collections.Generic;

class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            //int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);


            var stack = new Stack<char>();
            var calc = new Stack<char>();
            string a = Console.ReadLine();
            int temp = 1;
            int sum = 0;

            bool check = false;
            for (int i = 0; i < a.Length; i++)
            {
                char ch = a[i];
                if (ch == '(')
                {
                    stack.Push(ch);
                    temp *= 2;
                }
                else if (ch == '[')
                {
                    stack.Push(ch);
                    temp *= 3;
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(')
                    {
                        sum = 0;
                        break;
                    }

                    if (a[i - 1] == '(')
                        sum += temp;

                    stack.Pop();
                    temp /= 2;
                }
                else if (ch == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[')
                    {
                        sum = 0;
                        break;
                    }

                    if (a[i - 1] == '[')
                        sum += temp;

                    stack.Pop();
                    temp /= 3;
                }
            }


            if (temp ==1)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(0);
            }

            sw.Flush(); sw.Close();
        }

    }
}
