using System;
using System.IO;

namespace Task1
{
    class MainClass
    {
        static string Palindrome(string s,int i,int j)
        {
            if (i > j) return "Yes";
            if (s[i] != s[j]) return "No";
            return Palindrome(s, i + 1, j - 1);

        }
        public static void Main(string[] args)
        {
            StreamReader st = new StreamReader("input.txt");
            string s = st.ReadLine();

            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(Palindrome(s, 0, s.Length - 1));
            sw.Close();
        }
    }
}
