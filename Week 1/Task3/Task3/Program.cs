using System;

namespace Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] a1 = new int[2 * n];
            string[] s = Console.ReadLine().Split();

            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            int x = 0;
            for(int j = 0; j < a.Length; j++)
            {
                a1[x] = a[j];
                a1[x+1] = a[j];
                x += 2;
            }
            for(int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i] + " ");
            }
        }
    }
}
