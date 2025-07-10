
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        string S = Console.ReadLine();
        string T= Console.ReadLine();


        while (S.Length<T.Length)
        {
            if (T[^1] == 'A')
            {
                T = T[..^1];
            }
            else 
            {
                T = T[..^1];
                T = new string(T.Reverse().ToArray());
            }
        }

        sw.WriteLine(S == T ? 1 : 0);
        sw.Flush(); sw.Close();
    }
}