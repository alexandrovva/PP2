using System;
using System.IO;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = "/Users/definix/Documents";
            FileStream fs = File.Create(path);

        }
    }
}
