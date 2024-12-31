
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);



        for (int i = 0; i < input; i++) 
        {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] note = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            Array.Sort(note);

            count = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < count; j++)
            {
                int left = 0, right = note.Length - 1;
                result = 0;
                while (left <= right)
                {
                    int mid = (left + right) / 2;

                    if (note[mid] == nums[j])
                    {
                        result = 1;
                        break;
                    }
                    else if (note[mid] < nums[j])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                
                    sw.WriteLine(result);
                
            }

            Array.Clear(note);
        }

        sw.Flush(); sw.Close();

    }
}
