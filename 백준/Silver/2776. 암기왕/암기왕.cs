
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var note = new SortedSet<int>();

        for (int i = 0; i < input; i++) 
        {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for(int j = 0; j < count; j++) 
            {
                note.Add(nums[j]);
            }

            count = Convert.ToInt32(Console.ReadLine());
            nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < count; j++)
            {
                if (note.Contains(nums[j])) 
                {
                    sw.WriteLine(1);
                }
                else
                {
                    sw.WriteLine(0);
                }
            }

            note.Clear();
        }

        sw.Flush(); sw.Close();

    }
}
