using System.Linq;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(Console.ReadLine());
        HashSet<string> index = new HashSet<string>();
        string reverse = "" ;
        for (int i = 0; i < n; i++)
        {
            string password = Console.ReadLine();
            index.Add(password);
            reverse = new string (password.Reverse().ToArray());
            if (index.Contains(reverse))
            {
                break;
            }
            
        }
        
        sw.WriteLine($"{reverse.Length} {reverse[reverse.Length/2]}");

        sw.Flush(); sw.Close();
    }

}
