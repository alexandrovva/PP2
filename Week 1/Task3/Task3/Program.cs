using System;

namespace Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //количество чисел сразу переведенных из строки в int
            int[] a = new int[n]; //массив для введенных чисел
            int[] a1 = new int[2 * n]; //массив с удвоенными цифрами
            string[] s = Console.ReadLine().Split(); //вводим числа как строку, сразу разделяя

            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]); //преобразуем числа из строки в int и записываем в массив
            }
            int x = 0; //для продвижения по второму массиву, где все удвоенно
            for(int j = 0; j < a.Length; j++)
            {
                a1[x] = a[j]; //0-ой элемент первого массива сталовится 1
                a1[x+1] = a[j]; //1-ый элемент становится 1
                x += 2; //следующие места для чисел нового массива: 2 и 3
            }
            for(int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i] + " ");
            }
        }
    }
}
