using System.Text;

class Program
{
    static Stack<char> front = new Stack<char>();
    static Stack<char> back = new Stack<char>();
    static char[] input;
    static char c;
    static StringBuilder sb = new StringBuilder();
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string str = Console.ReadLine();
        front = new Stack<char>();
        back = new Stack<char>();

        for (int i = 0; i < str.Length; i++)
        {
            front.Push(str[i]);
        }
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            input = Array.ConvertAll( Console.ReadLine().Split(" "),Convert.ToChar);
            char com = input[0];
            if (com == 'P')
            {
                c = input[1];
            }

            Commend(com);
        }

        char[] frontArr = front.ToArray();
        Array.Reverse(frontArr);
        foreach (var c in frontArr)
        {
            sb.Append(c);
        }

        while (back.Count>0)
        {
            sb.Append(back.Pop());
        }

        

        sw.WriteLine(sb.ToString());
        sw.Flush(); sw.Close();
    }

    static void Commend(char com) 
    {
        if (com=='L')
        {
            if (front.Count>0)
            {
                back.Push(front.Pop());
            }
            
        }else if (com == 'D')
        {
            if (back.Count > 0)
            {
                front.Push(back.Pop());
            }
        }
        else if (com == 'B')
        {
            if (front.Count > 0)
            {
                front.Pop();
            }
        }
        else if (com == 'P')
        {
            front.Push(c);
        }
        
    }
}
