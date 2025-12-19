
using System.Xml.Schema;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[] parnet;
    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int n = nm[0];
        int m = nm[1];

        parnet = new int[n + 1];
        for (int i = 1; i < parnet.Length; i++)
        {
            parnet[i] = i;
        }

        int[] truthInput = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int truthCount = truthInput[0];
        int[] truthPeople = new int[truthCount];
        for (int i = 0; i < truthCount; i++)
        {
            truthPeople[i] = truthInput[i+1];
        }

        List<int[]> parties = new List<int[]>();

        for (int i = 0; i < m; i++)
        {
            int[] partyInput = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int partyCount = partyInput[0];

            int[] party = new int[partyCount];
            for (int j = 0; j < partyCount; j++)
            {
                party[j] = partyInput[j + 1];
            }

            parties.Add(party);

            for (int j = 1; j < partyCount; j++)
            {
                Union(party[0], party[j]);
            }

        }
        int count = 0;

        foreach (var party in parties)
        {
            bool canLie = true;
            foreach (int p in party)
            {
                foreach (int t in truthPeople)
                {
                    if (Find(p) ==Find(t))
                    {
                        canLie = false;
                        break;
                    }
                }
                if (!canLie)
                {
                    break;
                }
            }
            if (canLie)
            {
                count++;
            }
        }

        sw.WriteLine(count);
        

        sw.Flush(); sw.Close();
    }

    static int Find(int x)
    {
        if (parnet[x] != x)
        {
            parnet[x] = Find(parnet[x]);
        }

        return parnet[x];
    }

    static void Union(int a, int b) 
    {
        a = Find(a);
        b = Find(b);
        if (a != b) 
        {
            parnet[b] = a;
        }
    }
}
