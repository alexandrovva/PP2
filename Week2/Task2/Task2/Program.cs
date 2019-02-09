using System;
using System.IO;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt"); //поток считывания
            StreamWriter sw = new StreamWriter("output.txt"); //поток записи
            string[] s = sr.ReadLine().Split(); //считываем из файла строку, разделяя
            int[] a = new int[s.Length]; //массив для считываемых чисел
            bool f = true; //переменная проверки на простое число

            for (int i = 0; i < s.Length; i++)
            {
                a[i] = int.Parse(s[i]); //переводим данные в int и записываем в массив
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (a[i] == 1) //единицу исключаем
                {
                    continue;
                }

                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0 && a[i] != j) //если число при делении на число, отличное от себя, дает 0, то оно не простое
                    {
                        f = false; //показатель, что данное число не простое
                        break;
                    }
                }
                if (f == true) //если число прошло проверку и переменная не изменилась, число простое
                {

                    sw.Write(a[i]+" "); //выводим числа в другой файл через пробел
                }

            }
                sw.Close();
            
        }
    }
}