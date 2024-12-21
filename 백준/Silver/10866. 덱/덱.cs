class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int input =Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            
            List<int> deque = new List<int>();

            while (input-- > 0) 
            {
                string[] comarr = Console.ReadLine().Split(" ");
                string com = comarr[0];
                int num=0;
                if (comarr.Length ==2)
                {
                    num = Convert.ToInt32(comarr[1]);
                }

                commend(deque,com,num);
            }

            void commend(List<int> deque, string com, int num) 
            {
                int end = deque.Count;

                if (com == "push_front")
                {
                    deque.Insert(0, num);
                }
                else if (com == "push_back")
                {
                    deque.Insert(end, num);
                }
                else if (com == "pop_front")
                {
                    if (deque.Count>0)
                    {
                        sw.WriteLine(deque[0]);
                        deque.RemoveAt(0);
                    }
                    else
                    {
                        sw.WriteLine(-1);
                    }
                }
                else if (com == "pop_back")
                {
                    if (deque.Count > 0)
                    {
                        sw.WriteLine(deque[end-1]);
                        deque.RemoveAt(end-1);
                    }
                    else
                    {
                        sw.WriteLine(-1);
                    }
                }
                else if (com == "size")
                {
                    sw.WriteLine(deque.Count);
                }
                else if (com == "empty")
                {
                    if (deque.Count > 0)
                    {
                        sw.WriteLine(0);
                    }
                    else
                    {
                        sw.WriteLine(1);
                    }
                }
                else if (com == "front")
                {
                    if (deque.Count > 0)
                    {
                        sw.WriteLine(deque[0]);
                    }
                    else
                    {
                        sw.WriteLine(-1);
                    }
                }
                else if (com == "back")
                {
                    if (deque.Count > 0)
                    {
                        sw.WriteLine(deque[end-1]);
                    }
                    else
                    {
                        sw.WriteLine(-1);
                    }
                }
            }

            sw.Flush(); sw.Close();
        }
    }
}
