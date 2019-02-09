using System;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //число рядов
            for (int i = 1; i <= n; i++) //ряд
            {
                for (int j = 1; j <= i; j++) //кол-во звездочек в ряду
                {
                    Console.Write("[*]");
                }
                Console.WriteLine(); //переход на следующий ряд
            }
        }
    }
}
