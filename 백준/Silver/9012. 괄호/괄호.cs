using System;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var a = int.Parse(Console.ReadLine());
            int check = 0;
            StringBuilder sb = new StringBuilder();

            while (count< a)
            {
                string input = Console.ReadLine();

                foreach (char c in input) 
                {
                    if (c == '(')
                    {
                        check++;
                    }else if (c == ')') 
                    {
                        check--;
                    }
                    if (check < 0) 
                    {
                        break;
                    }
                }
                if (check == 0)
                {
                    sb.AppendLine("YES");
                }
                else if (check != 0)
                {
                    sb.AppendLine("NO");
                }

                check = 0;
                count++;
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}