

class Program
{
    static int n;

    static HashSet<string> peoples = new HashSet<string>();
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            CheckPeople(input);
        }

        List<string> sortedList = peoples.ToList();
        sortedList.Sort();
        sortedList.Reverse();

        foreach (var name in sortedList)
        {
            sw.WriteLine(name);
        }

        sw.Flush(); sw.Close();
    }

    static void CheckPeople(string[] input) 
    {
        string name = input[0];
        string log = input[1];

        if (log == "enter")
        {
            peoples.Add(name);
        }
        else if (log == "leave") 
        {
            peoples.Remove(name);
        }
    }

   
}
