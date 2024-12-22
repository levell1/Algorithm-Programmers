
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            var lList = new LinkedList<int>();
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int count = inputArr.Length;

            for (int i = 1; i <= count; i++)
            {
                int arrnum = count - i;
                if (inputArr[count-i] ==1)
                {
                    lList.AddFirst(i);
                }
                else if (inputArr[count - i] ==2)
                {
                    LinkedListNode<int> first = lList.First;
                    lList.AddAfter(first,i);
                }
                else if (inputArr[count - i] ==3) 
                {
                    lList.AddLast(i);
                }
            }

            sw.Write(string.Join(" ", lList));
            sw.Flush(); sw.Close();
        }
    }
}
