class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            //int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            var lList = new LinkedList<int>();
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int N = inputArr[0];
            int T = inputArr[1];
            int[] find = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            for (int i = 1; i <= N; i++)
            {
                lList.AddLast(i);
            }

            int sum = 0;
            for (int i = 0; i < T; i++)
            {
                int findNum = find[i];
                var Node = lList.First;
                if (Node.Value== findNum)
                {
                    lList.RemoveFirst();
                    continue;
                }
                int count = 0;
                
                while (true)
                {
                    count++;
                    Node = Node.Next;
                    if (Node.Value == findNum)
                    {
                        break;
                    }
                }

                if (count <= lList.Count/2)
                {
                    for (int j = 0; j < count; j++)
                    {
                        lList.AddLast(lList.First());
                        lList.RemoveFirst();
                    }
                    sum += count;
                }
                else
                {
                    for (int j = 0; j < lList.Count - count; j++)
                    {
                        lList.AddFirst(lList.Last());
                        lList.RemoveLast();
                    }
                    sum += lList.Count - count;
                }
                lList.RemoveFirst();
            }

            sw.Write(sum);
            sw.Flush(); sw.Close();
        }
    }
}
