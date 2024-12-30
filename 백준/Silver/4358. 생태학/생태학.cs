
class Program
{
    static void Main()
    {
        var reader = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        
        var dic = new SortedDictionary<string,int>();
        int count = 0;

        while (true) 
        {
            string input = Console.ReadLine();
            if (input == "" || input == null)
            {
                break;
            }

            count++;
            if (dic.ContainsKey(input))
            {
                dic[input]++;
            }
            else
            {
                dic.Add(input, 1);
            }
        }

        //var sortedByKey = dic.OrderBy(x => x.Key);

        foreach (var keyvalue in dic) 
        {
            double ratio = (keyvalue.Value / (double)count)*100;
            sw.WriteLine($"{keyvalue.Key} {ratio:F4}");
        }
        sw.Flush(); sw.Close();

    }
}
