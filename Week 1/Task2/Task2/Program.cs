using System;

namespace Task2
{
    class Student
    {
        public string name;
        public string surname;
        public int year;

        public Student(string name,string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student st2 = new Student("Anastassiya", "Nikitina");
            st2.year = 1;
            Console.WriteLine(st2);
        }
    }
}
