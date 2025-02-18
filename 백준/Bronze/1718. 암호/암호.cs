class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string str = Console.ReadLine();
        string key = Console.ReadLine();


        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                sw.Write(' ');
            }
            else
            {
                int a =  (int)str[i]- (int)key[i % key.Length];
                if (a <= 0)
                {
                    a += 'z';
                }
                else {
                    a += 'a'-1;
                }
                sw.Write((char)(a));
            }
        }
        sw.Flush(); sw.Close();
    }

}
