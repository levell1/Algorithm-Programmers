
using System.Text;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        StringBuilder result = new StringBuilder();
        string input;
        int oneCount = 0;
        while ((input = Console.ReadLine()) !="#")
        {
            oneCount = input.Count(c => c == '1');
            if (input[^1] == 'e' )
            {
                if (oneCount % 2 == 0)
                {
                    input = input.Replace('e', '0');
                }
                else
                {
                    input = input.Replace('e', '1');
                }
            }
            else
            {
                if (oneCount % 2 == 0)
                {
                    input = input.Replace('o', '1');
                }
                else
                {
                    input = input.Replace('o', '0');
                }
            }


            result.Append(input);
            result.Append("\n");
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

}