
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        List<int> list = new List<int>();
        for (int i = 1; i <= 30; i++)
        {
            list.Add(i);
        }
        for (int i = 0; i < 28; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            list.Remove(num);
        }

        sw.WriteLine(string.Join("\n", list));
        sw.Flush(); sw.Close();

    }
}
