
using System.Text;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        string[] input = Console.ReadLine().Split(" ");
        bool isTag = false;

        for (int i = 0; i < input.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            for (int j = 0; j < input[i].Length; j++)
            {
                char c = input[i][j];
                if (c == '<')
                {
                    isTag = true;
                    sw.Write(sb.ToString());
                    sb.Clear();
                }

                if (c == '>')
                {
                    isTag = false;
                    sw.Write(c);
                    continue;
                }

                if (!isTag) 
                {
                    sb.Insert(0, c);
                }
                else
                {
                    sw.Write(c);
                }

            }
            sw.Write(sb.ToString());
            sw.Write(' ');
        }
        sw.Flush(); sw.Close();
    }
}
