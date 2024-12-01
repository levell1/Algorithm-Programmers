using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        while (T-- > 0)
        {
            int k = int.Parse(Console.ReadLine());
            var maxHeap = new SortedDictionary<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var minHeap = new SortedDictionary<int, int>();

            for (int i = 0; i < k; i++)
            {
                var input = Console.ReadLine().Split();
                string op = input[0];
                int num = int.Parse(input[1]);

                if (op == "I")
                {
                    AddToHeap(maxHeap, num);
                    AddToHeap(minHeap, num);
                }
                else if (op == "D" &&maxHeap.Count>0)
                {
                    if (num == 1)
                    {
                        RemoveFromHeap(maxHeap, minHeap);
                    }
                    else 
                    {
                        RemoveFromHeap(minHeap, maxHeap);
                    }
                    
                }
            }

            // 결과 출력
            if (maxHeap.Count == 0)
            {
                sw.WriteLine("EMPTY");
            }
            else
            {
                sw.WriteLine($"{GetTop(maxHeap)} {GetTop(minHeap)}");
            }
        }

        sw.Flush();
        sw.Close();
    }

    static void AddToHeap(SortedDictionary<int, int> heap, int num)
    {
        if (!heap.ContainsKey(num))
        {
            heap[num] = 0;
        }
        heap[num]++;
    }

    static void RemoveFromHeap(SortedDictionary<int, int> primaryHeap, SortedDictionary<int, int> secondaryHeap)
    {

        int top = GetTop(primaryHeap);
        if (--primaryHeap[top] == 0)
        {
            primaryHeap.Remove(top);
        }

        if (secondaryHeap.ContainsKey(top))
        {
            if (--secondaryHeap[top] == 0)
            {
                secondaryHeap.Remove(top);
            }
        }
    }

    static int GetTop(SortedDictionary<int, int> heap)
    {
        foreach (var kvp in heap)
        {
            return kvp.Key;
        }
        return 0;
    }
}
