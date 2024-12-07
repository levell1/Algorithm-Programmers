class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        //int input = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int N = inputArr[0];
        int M = inputArr[1];
        List<int> list = new List<int>();

        mn(1, 0);
        void mn(int start, int depth) 
        {
            if (depth==M)
            {
                sw.WriteLine(string.Join(" ", list));
                return;
            }

            for (global::System.Int32 i = start; i <= N; i++)
            {
                list.Add(i);
                mn(i+1, depth+1);
                list.RemoveAt(list.Count-1);
            }
        }


        
        sw.Flush(); sw.Close();
        Console.ReadLine();
       
    }
}