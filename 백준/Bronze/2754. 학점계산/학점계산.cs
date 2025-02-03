
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        float result = 0f;
        string input = Console.ReadLine();


        switch (input[0]) 
        {
            case 'A':
                result = 4;
                break;
            case 'B':
                result = 3;
                break;
            case 'C':
                result = 2;
                break;
            case 'D':
                result = 1;
                break;
                default: result = 0; break;
        }
        if (result!=0)
        {
            switch (input[1])
            {
                case '+':
                    result = result + 0.3f;
                    break;
                case '-':
                    result = result - 0.3f;
                    break;
                case '0':
                    break;
                default: result = 0; break;
            }
        }
        


        sw.WriteLine(result.ToString("0.0"));
        sw.Flush(); sw.Close();

    }
}
