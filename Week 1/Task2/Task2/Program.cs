using System;
using System.Collections.Generic;

namespace Task2
{
    class Student
    {
        public string name;
        public string surname;
        public int year;

        public Student(string name, string surname, int year)
        {
            this.name = name;
            this.surname = surname;
            this.year = year;
        }
        public void F()
        {
            Console.WriteLine(name+" "+surname+" "+year);
        }
    }


    class MainClass
    {
        static void Main(string[] args)
        {

        }
    }
}

