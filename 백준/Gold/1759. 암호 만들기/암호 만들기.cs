
class Program
{
    static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    static int[] input;
    static int L, C;
    static char[] result;
    static string[] resultPasswords;
    static char[] alphabet;
    static HashSet<String> passwords = new HashSet<string>();
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        L = input[0];
        C = input[1];

        alphabet = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToChar);
        Array.Sort(alphabet);

        result = new char[L];
        PassWord(0, 0);


        sw.Flush(); sw.Close();
    }

    static void PassWord(int start, int count)
    {
        if (count == L)
        {
            int vowelsCount = 0;
            int consonantCount = 0;
            foreach (var c in result)
            {
                if (vowels.Contains(c))
                    vowelsCount++;
                else
                    consonantCount++;
            }

            if (vowelsCount >= 1 && consonantCount >= 2)
            {
                Console.WriteLine(new string(result));
            }
            return;
        }

        for (int i = start; i < C; i++)
        {
            result[count] = alphabet[i];
            PassWord(i + 1, count + 1);
        }
    }
}
