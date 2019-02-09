using System;
using System.IO;

namespace Task1
{
    class MainClass
    {
        static string Palindrome(string s,int i,int j) //рекурсия для проверки палиндрома
        {
            if (i > j) return "Yes"; //если указатели перешели друг друга, то это палиндром
            if (s[i] != s[j]) return "No"; 
            return Palindrome(s, i + 1, j - 1); //сдвигаем указатели вправл и влево соответственно

        }
        public static void Main(string[] args)
        {
            StreamReader st = new StreamReader("input.txt"); 
            string s = st.ReadLine(); //считываем

            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(Palindrome(s, 0, s.Length - 1)); //переход к функции-рекурсии
            sw.Close();
        }
    }
}
