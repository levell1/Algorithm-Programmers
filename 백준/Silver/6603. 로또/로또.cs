
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            //int T = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            

            while (true) 
            {
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                if (nums.Length==1)
                {
                    break;
                }
                
                List<int> list = nums.Skip(1).ToList();
                list.Sort();
                List<int> sixnums = new List<int>();
                comb(list,6, sixnums,0);
                sw.WriteLine();
            }

            
            sw.Flush(); sw.Close();

            void comb(List<int> list, int k, List<int> current, int start)
            {
                if (current.Count == k) 
                {
                    sw.WriteLine(string.Join(" ", current));
                    return;
                }

                for (int i = start; i < list.Count; i++)
                {
                    current.Add(list[i]);
                    comb(list, k, current, i+1);
                    current.RemoveAt(current.Count-1);
                }
            }

           
        }
    }
}
