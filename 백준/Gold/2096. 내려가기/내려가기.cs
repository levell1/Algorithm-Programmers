
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int T = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            int[] minCur = new int[3];
            int[] minPre = new int[3];
            int[] maxCur = new int[3];
            int[] maxPre = new int[3];
            int[] stairs = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int i = 0; i < 3; i++)
            {
                minPre[i] = minCur[i] = stairs[i];
                maxPre[i] = maxCur[i] = stairs[i];
            }
            
            for (int i = 1; i < T; i++)
            {
                stairs = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                minCur[0] = stairs[0] + Math.Min(minPre[0], minPre[1]);
                minCur[1] = stairs[1] + Math.Min(minPre[0], Math.Min(minPre[1], minPre[2])); 
                minCur[2] = stairs[2] + Math.Min(minPre[1], minPre[2]);

                maxCur[0] = stairs[0] + Math.Max(maxPre[0], maxPre[1]);
                maxCur[1] = stairs[1] + Math.Max(maxPre[0], Math.Max(maxPre[1], maxPre[2]));
                maxCur[2] = stairs[2] + Math.Max(maxPre[1], maxPre[2]);

                Array.Copy(minCur, minPre, 3);
                Array.Copy(maxCur, maxPre, 3);
            }

            int max = Math.Max(maxCur[0], Math.Max(maxCur[1], maxCur[2]));
            int min = Math.Min(minCur[0], Math.Min(minCur[1], minCur[2]));
            sw.WriteLine($"{max} {min}");
            sw.Flush(); sw.Close();
        }
    }
}
