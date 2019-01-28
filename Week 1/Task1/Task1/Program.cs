using System;
using System.Collections.Generic;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int c = 0; //счетчик простых чисел
            int x = int.Parse(Console.ReadLine()); //число элементов, которые далее будут вводиться
            int[] a = new int[x]; //массив для введенных чисел
            List<int> l = new List<int>(); //лист для простых чисел
            string[] s = Console.ReadLine().Split(); //вводим строку с числами, сразу разделяя их при считывании строки

            for (int i = 0; i < x; i++)
            {
                a[i] = int.Parse(s[i]); //переводим из строки в int и добавляем в массив
            }

            for (int i = 0; i < a.Length; i++)
            {
                bool k = true; //переменная для проверки в конце цикла: простое число или нет
                if (a[i] == 1) //единица сразу исключается
                {
                    k = false;
                }
                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0 && a[i] != j) //если число в остатке при делении не на себя дает 0, оно не простое
                    {
                        k = false; //число уже не простое, поэтому выходим из цикла
                        break;
                    }
                }

                if (k == true) //если число прошло все проверки и переменная осталась true, число простое
                {
                    l.Add(a[i]); //добавляем данное простое число в лист
                    c++; //увеличиваем счетчик простых чисел 
                }
            }


            Console.WriteLine(c); //выводим кол-во простых чисел
            foreach (int i in l) //пробегаемся по листу и выводим все содержимое через пробел
            {
                Console.Write(i+" ");

            }

        }
    }
}


