using System;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            int[] a1 = new int[x];
            string[] arr = Console.ReadLine().Split();
            for (int i = 0; i < x; i++)
            {

             
                a[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i]%j!=0)
                    { 
                    a1[i] = a[i];
                    }
                }
            }
            foreach(int k in a1)
            Console.Write(k);
        }
    }
}
