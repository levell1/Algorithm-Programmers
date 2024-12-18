class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            //int input =Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U' };
            char end = ' ';
            while (true) 
            {
                string input = Console.ReadLine();
                char[] inputtochar = input.ToCharArray();
                if (inputtochar[0]=='#')
                {
                    break;
                }
                int count = 0;
                foreach (char c in inputtochar) 
                {
                    if (vowel.Contains(c))
                    {
                        count++;
                    }
                }
                sw.WriteLine(count);
            }

            sw.Flush(); sw.Close();
        }
    }
}
