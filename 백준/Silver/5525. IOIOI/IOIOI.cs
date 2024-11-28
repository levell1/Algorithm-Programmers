class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());


        int N = Convert.ToInt32(Console.ReadLine());
        int M = Convert.ToInt32(Console.ReadLine());
        string S = Console.ReadLine();

        string IO = "I";
        
        for (int i = 1; i <= N; i++)
        {
            IO += new string("OI");
        }

        int count = 0;
        for (int i = 0; i <= S.Length-IO.Length; i++)
        {
            if (S[i] == 'I')
            {
                if (S.Substring(i, IO.Length) ==IO)
                {
                    count++;
                    i++;
                }
            }
        }

        sw.WriteLine(count);
        

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}