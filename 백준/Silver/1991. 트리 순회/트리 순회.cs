
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int T = Convert.ToInt32(Console.ReadLine());
        //int first = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        
        List<int>[] list = new List<int>[T];

        for (int i = 0; i < T; i++)
        {
            list[i] = new List<int>();
        }

        for (int i = 0; i < T; i++)
        {
            string[] nodes = Console.ReadLine().Split(" ");
            int node = Convert.ToInt32(nodes[0][0]);
            int leftNode = Convert.ToInt32(nodes[1][0]);
            int rightNode = Convert.ToInt32(nodes[2][0]);


            list[node - 'A'].Add(leftNode-'A');;
            list[node - 'A'].Add(rightNode - 'A');
        }

        string pre ="";
        string inord = "";
        string post = "";

        preorder(0);
        sw.WriteLine(pre);
        sw.WriteLine(inord);
        sw.WriteLine(post);

        sw.Flush(); sw.Close();
        Console.ReadLine();

        void preorder (int firstnode) 
        {
            char node = (char)(firstnode +'A');
            pre += node;

            int left = list[firstnode][0];
            int right = list[firstnode][1];

            if (list[firstnode][0] != '.' -'A')
            {
                preorder(list[firstnode][0]);
            }
            inord += node;

            if (list[firstnode][1] != '.' - 'A')
            {
                preorder(list[firstnode][1]);
            }
            post += node;
        }
    }
}