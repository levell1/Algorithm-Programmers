using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var A = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            while (count <A) 
            {
                string[] input = Console.ReadLine().Split(' ');
                
                foreach (string s in input) 
                {
                    string newStr = new string(s.Reverse().ToArray());
                    sb.Append(newStr+' ');
                }
                sb.AppendLine();
                count++;
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}