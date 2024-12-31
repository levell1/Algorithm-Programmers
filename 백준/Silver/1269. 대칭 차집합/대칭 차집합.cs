
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int ab = inputArr[0];
        int ba = inputArr[1];

        var nums1 =new HashSet<int>();
        var nums2 = new HashSet<int>();

        int[] first = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        for (int i = 0; i < inputArr[0]; i++)
        {
            nums1.Add(first[i]);
        }

        int[] second = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        for (int i = 0; i < inputArr[1]; i++)
        {
            if (nums1.Contains(second[i])) 
            {
                ab--;
            }
            nums2.Add(second[i]);
        }

        for (int i = 0; i < inputArr[0]; i++)
        {
            if (nums2.Contains(first[i]))
            {
                ba--;
            }
        }


        Console.WriteLine($"{ab+ba}");
        
        sw.Flush(); sw.Close();

    }
}
