
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        string input = Console.ReadLine();
        string[] strings = new string[input.Length];
        strings[0]= input;
        for (int i = 1; i < strings.Length; i++) 
        {
            strings[i] = strings[i-1].Remove(0, 1);
        }

        var sortedStrings = strings.OrderBy(w => w).ToArray();

        foreach (string s in sortedStrings) 
        {
            sw.WriteLine(s);
        }
        

        sw.Flush(); sw.Close();
    }
}
