
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        string input = Console.ReadLine();
        var startpos = new Stack<int>();
        var position = new List<(int start, int end)>();
        var result = new HashSet<string>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                startpos.Push(i);
            }
            if (input[i] == ')')
            {
                position.Add((startpos.Pop(), i));
            }
        }

        int count = position.Count;
        for (int i = 1; i < (1 << count); i++)  // count 개로 만들 수 있는 개수  1<<count 개 
        {                                   // ex count = 3  1000 -> 8개 2의 3승 개
            var remove = new List<int>();
            for (int j = 0; j < count; j++)
            {
                if ((i & (1 << j)) != 0)
                {
                    remove.Add(position[j].start);
                    remove.Add(position[j].end);
                }
            }

            var newString = new List<char>();
            for (int j = 0; j < input.Length; j++)
            {
                if (!remove.Contains(j))
                {
                    newString.Add(input[j]);
                }

            }
            result.Add(new string(newString.ToArray()));
        }

        List<string> sortedResult = result.ToList();
        sortedResult.Sort();
        foreach (var str in sortedResult)
        {
            sw.WriteLine(str);
        }

        sw.Flush(); sw.Close();

    }
}
