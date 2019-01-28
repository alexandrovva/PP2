using System;
using System.Collections.Generic;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int c = 0;
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            List<int> l = new List<int>();
            string[] s = Console.ReadLine().Split();

            for (int i = 0; i < x; i++)
            {
                a[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                bool k = true;
                if (a[i] == 1)
                {
                    k = false;
                }
                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0 && a[i] != j)
                    {
                        k = false;
                        break;
                    }
                }

                if (k == true)
                {
                    l.Add(a[i]);
                    c++;
                }
            }


            Console.WriteLine(c);
            foreach (int i in l)
            {
                Console.Write(i+" ");

            }

        }
    }
}


