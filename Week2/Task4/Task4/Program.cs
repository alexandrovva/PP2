using System;
using System.IO;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = "/Users/definix/Documents/path"; //где создаем папку
            DirectoryInfo di = Directory.CreateDirectory(path); //создание папки

            System.IO.File.Create("/Users/definix/Documents/path/file.txt"); //создание файла в первой папке

            string path1 = "/Users/definix/Documents/path1"; //где создаем вторую папку
            DirectoryInfo di1 = Directory.CreateDirectory(path1); //создание второй папки

            File.Copy("/Users/definix/Documents/path/file.txt", "/Users/definix/Documents/path1/file.txt"); //копируем файл во вторую папку

            File.Delete("/Users/definix/Documents/path/file.txt"); //удаляем файл из первой папки
        }
    }
}



