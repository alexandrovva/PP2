using System;
using System.IO;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string[] s = sr.ReadLine().Split();
            int[] a = new int[s.Length];
            bool f = true;

            for (int i = 0; i < s.Length; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (a[i] == 1)
                {
                    continue;
                }

                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0 && a[i] != j)
                    {
                        f = false;
                        break;
                    }
                }
                if (f == true)
                {

                    sw.Write(a[i]+" ");
                }

            }
                sw.Close();
            
        }
    }
}