
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int input = Convert.ToInt32(Console.ReadLine());

        int left = input % 10;
        int right = (input / 10 + left)%10;
        int cur = left * 10 + right;
        int count = 1;
        while (cur!=input)
        {
            count++;
            left = cur % 10;
            right = (cur / 10 + left) % 10;
            cur = left * 10 + right;
        }

        sw.WriteLine(count);
        sw.Flush(); sw.Close();

    }
}
