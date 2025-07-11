
class Program
{
    static string S;
    static string T;
    static bool result = false;
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        S= Console.ReadLine();
        T= Console.ReadLine();


        find(T);

        sw.WriteLine(result ? 1 : 0);
        sw.Flush(); sw.Close();
    }

    static void find(string cur) 
    {
        if (result)
        {
            return;
        }

        if (cur.Length<S.Length)
        {
            return;
        }

        if (S == cur)
        {
            result = true;
            return;
        }

        if (cur[^1] == 'A')
        {
            find(cur[..^1]);
        }

        if (cur[0] == 'B')
        {
            string next = new string(cur[1..].Reverse().ToArray());
            find(next);
        }

    }
}