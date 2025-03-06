
using System.Text;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        string str = Console.ReadLine();
        string boom = Console.ReadLine();

        Stack<char> stack = new Stack<char>();
        StringBuilder a = new StringBuilder();
        string reverse = new string(boom.Reverse().ToArray());

        for (int i = 0; i < str.Length; i++)
        {
            stack.Push(str[i]);
            if (str[i] == boom[boom.Length-1])
            {

                for (int j = 0; j < boom.Length; j++)
                {
                    if (stack.Count > 0) 
                    {
                        char c = stack.Pop();
                        a.Append(c);
                    }
                    
                }

                if (a.ToString()== reverse)
                {
                    a.Clear();
                }

                for (int j = 1; j <= a.Length; j++)
                {
                    stack.Push(a[a.Length - j]);
                }
                a.Clear();
            }
        }

        char[] chars = stack.ToArray();
        Array.Reverse(chars);
        if (chars.Length>0)
        {
            sw.Write(chars);
        }
        else
        {
            sw.Write("FRULA");
        }

        sw.Flush(); sw.Close();
    }
}
