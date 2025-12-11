

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        string s = Console.ReadLine();
        int[] alp = new int[26];
        bool check= false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] <='Z' )
            {
                alp[s[i] - 'A']++;
            }
            else
            {
                alp[s[i] - 'a']++;
            }

        }
        int count = alp.Max();
        char a = '?';
        for (int i = 0; i < alp.Length; i++)
        {
            if (count == alp[i])
            {
                if (check)
                {
                    a = '?';
                    break;
                }
                check = true;
                a = (char)(i+'A');
            }
        }

        sw.WriteLine(a);
        sw.Flush(); sw.Close();
    }

}
