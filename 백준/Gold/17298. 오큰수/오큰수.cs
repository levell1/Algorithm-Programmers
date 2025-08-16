
using System.ComponentModel;

class Program
{
    static int n;
    static int[] A;
    static int[] result;
    static Stack<int> stack = new Stack<int>();
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        n = Convert.ToInt32(Console.ReadLine());
        A = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = -1;
        }
        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && A[stack.Peek()] < A[i])
            {
                int index = stack.Pop();
                result[index] = A[i];
            }
            stack.Push(i);
        }

        foreach (var item in result)
        {
            sw.Write($"{item} ");
        }

        

        sw.Flush(); sw.Close();
    }



    static int NGE(int i) 
    {
        int nge = -1;
        
        for (int j = i+1; j < n; j++)
        {
            if (A[i] < A[j])
            {
                nge = A[j];
                break;
            }
        }
        return nge;
    }
}
