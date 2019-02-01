using System;

namespace T2
{
    class Student
    {
        public string name;
        public string id;
        public int year;

        public void PrintInfo()
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            st.name = s1;
            st.id = s2;
            int x = int.Parse(s3);
            x = x + 1;
            st.year = x;
            st.PrintInfo();
        }
    }
}
