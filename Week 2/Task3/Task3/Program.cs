using System;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void Spaces(int l)
        {
            for (int i = 0; i < l; i++)
                Console.Write("     ");
        }

        public static void F(DirectoryInfo dir, int l)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                Spaces(l);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Spaces(l);
                Console.WriteLine(d.Name);
                F(d, l + 1);
            }
        }


        public static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/definix/Documents/PP2");
            F(dir, 0);
           
        }
    }
}
