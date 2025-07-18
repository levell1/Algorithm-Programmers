
using System.Text;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        bool check = inputArr[0] < inputArr[1] ? true : false;


        int num1 = check? inputArr[0]:inputArr[1];
        int num2 = check ? inputArr[1] : inputArr[0];


        int h = Math.Abs((num2-1) % 4 - (num1-1) % 4);
        int w = Math.Abs((num2-1) / 4 - (num1-1) / 4);


        sw.WriteLine(h+w);
        sw.Flush(); sw.Close();
    }

}