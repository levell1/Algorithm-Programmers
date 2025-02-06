
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int numCount = inputArr[0];
        int delCount = inputArr[1];

        string input = Console.ReadLine();

        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            while (stack.Count > 0 && delCount > 0 && stack.Peek() < c)
            {
                stack.Pop();
                delCount--;
            }
            stack.Push(c);
        }

        while (delCount > 0)
        {
            stack.Pop();
            delCount--;
        }


        sw.WriteLine(string.Concat(stack.Reverse()));
        sw.Flush(); sw.Close();

    }
}
