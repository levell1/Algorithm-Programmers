using System;
using System.Collections.Generic;


class Program
{
    public class agename 
    {
        public int age;
        public string name;
        public int index;

        public agename(int age, string name, int index) 
        {
            this.age = age;
            this.name = name;
            this.index = index;
        }
    }
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);
        List<agename> list = new List<agename>();
        int age = 0;
        for (int i = 0; i < testcase; i++)
        {
            string agename = Console.ReadLine();
            string[] agenames = agename.Split(' ');
            age = Convert.ToInt32(agenames[0]);
            list.Add(new agename(age, agenames[1],i));
        }

        list.Sort((a, b) =>
        {
            if (a.age != b.age)
                return a.age.CompareTo(b.age); // 나이순으로 정렬
            return a.index.CompareTo(b.index);
        });

        foreach (var agename in list)
        {
            Console.WriteLine($"{agename.age} {agename.name}");
        }

        Console.ReadLine();
    }
    
}
