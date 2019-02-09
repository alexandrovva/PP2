using System;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void Spaces(int l) //генерация отступов
        {
            for (int i = 0; i < l; i++)
                Console.Write("     ");
        }

        public static void F(DirectoryInfo dir, int l)
        {
            foreach (FileInfo f in dir.GetFiles()) //берем файлы из заданной папки
            {
                Spaces(l); //отступ
                Console.WriteLine(f.Name); //выводим имена файлов
            }
            foreach (DirectoryInfo d in dir.GetDirectories()) //для каждой папки выводим свои папки внутри
            {
                Spaces(l); 
                Console.WriteLine(d.Name); //имя папки
                F(d, l + 1); //рекурсивно выводим по очереди для каждой папки файлы внутри, переходя к новой папке делаем отступ
            }
        }


        public static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/definix/Documents/PP2"); //выводим деревообразно все из папки PP2
            F(dir, 0); //передаем направление и 0 отступ для первого вывода
           
        }
    }
}
