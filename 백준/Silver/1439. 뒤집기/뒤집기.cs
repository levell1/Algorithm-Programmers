
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        string input = Console.ReadLine();

        int len = input.Length;
        int zeroCount = 0;
        int oneCount = 0;
        for (int i = 0; i < len-1; i++)
        {
            if (input[i] != input[i+1])
            {
                if (input[i]=='0')
                {
                    zeroCount++;
                }
                else
                {
                    oneCount++;
                }
            }
        }

        if (input[len - 1] == '0')
        {
            zeroCount++;
        }
        else
        {
            oneCount++;
        }
        

        int result = zeroCount<oneCount? zeroCount:oneCount;

        sw.WriteLine($"{result}");
        sw.Flush(); sw.Close();

    }
}
