class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
           

            for (int i = 0; i < input; i++)
            {
                string inputPassword = Console.ReadLine();
                var result = new List<string>();
                var cursorLeft = new Stack<char>();
                var cursorRight = new Stack<char>();

                foreach (char ch in inputPassword)
                {
                    if (ch == '<')
                    {
                        if (cursorLeft.Count > 0)
                            cursorRight.Push(cursorLeft.Pop());
                    }
                    else if (ch == '>')
                    {
                        if (cursorRight.Count > 0)
                            cursorLeft.Push(cursorRight.Pop());
                    }
                    else if (ch == '-')
                    {
                        if (cursorLeft.Count > 0)
                            cursorLeft.Pop();
                    }
                    else
                    {
                        cursorLeft.Push(ch);
                    }
                }

                int count = cursorLeft.Count;
                for (int j = 0; j < count; j++)
                {
                    result.Add(cursorLeft.Pop().ToString());
                }
                result.Reverse();
                count = cursorRight.Count;
                for (int j = 0; j < count; j++)
                {
                    result.Add(cursorRight.Pop().ToString());
                }
                sw.WriteLine(string.Join("", result));
            }
            
            sw.Flush(); sw.Close();
        }
    }
}
