class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var stack = new Stack<int>();

        int[] building = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        var result = new (int count, int near)[input];

        var leftBuilding = new int[input];
        var rightBuilding = new int[input];
        var near = new int[input];


        for (int i = 0; i < input; i++)
        {
            while (stack.Count > 0 && building[stack.Peek()] <= building[i])
            {
                stack.Pop();
            }
            leftBuilding[i] = stack.Count;
            if (stack.Count>0)
            {
                near[i] = stack.Peek() + 1;
            }
            stack.Push(i);
        }

        stack.Clear();
        for (int i = input-1; i >= 0 ; i--)
        {

            while (stack.Count > 0 && building[stack.Peek()] <= building[i])
            {
                stack.Pop();
            }
            rightBuilding[i] = stack.Count;
            if (stack.Count > 0)
            {
                if (i-near[i]> stack.Peek() - i-1 || near[i] ==0)
                {
                    near[i] = stack.Peek()+1;
                }
            }
            stack.Push(i);
        }

        for (int i = 0; i < input; i++)
        {
            result[i].count = leftBuilding[i] + rightBuilding[i];
            result[i].near = near[i];
        }

        foreach (var output in result)
        {
            if (output.count == 0)
            {
                sw.WriteLine(0);
            }
            else
            {
                sw.WriteLine($"{output.count} {output.near}");
            }
        }

        sw.Flush(); sw.Close();

    }
}
