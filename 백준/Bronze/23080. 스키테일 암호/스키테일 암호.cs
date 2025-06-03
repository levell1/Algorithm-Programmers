
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int input = Convert.ToInt32(Console.ReadLine());
        string str = Console.ReadLine();

        
        for (int i = 0; i < str.Length; i++)
        {
            if ((i+1)%input==1)
            {
                sw.Write(str[i]);
            }
        }

        sw.Flush(); sw.Close();
    }
}
