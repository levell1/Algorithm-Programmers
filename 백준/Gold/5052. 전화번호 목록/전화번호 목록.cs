
class Program
{

    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string result = "YES";
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];

            for (int j = 0; j < n; j++)
            {
                arr[j] =Console.ReadLine();
            }
            Array.Sort(arr);
            for (int j = 1; j < n; j++)
            {
                if (arr[j].StartsWith(arr[j - 1]))
                {
                    result = "NO";
                    break;
                }
            }
            sw.WriteLine(result);
        }
       
        sw.Flush(); sw.Close();
    }

}