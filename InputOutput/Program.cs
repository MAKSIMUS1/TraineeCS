using System;
using System.IO.Compression;
using System.Security.Principal;
using System.Text;

namespace InputOutput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var fileManager = new FileManager();
            var dirManager = new DirectoryManager();

            Console.Write("Введите имя файла: ");
            var fileName = Console.ReadLine();

            Console.WriteLine("Введите путь до файла: ");
            var filePath = Console.ReadLine();

            if (!Directory.Exists(filePath))
            {
                Console.WriteLine("Такого пути нет");
                return;
            }

            var files = fileManager.FindFiles(filePath, fileName);

            if (files.Count == 0)
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            foreach (var file in files)
            {
                Console.WriteLine("\n--- Содержимое файла ---");
                Console.WriteLine($"{file}");
                fileManager.ReadFile(file);

                Console.WriteLine($"\nСжать файл({file})? (y/n)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    fileManager.CompressFile(file);
                }
            }

            //Task extra
            string rootPath = @"F:\temp";
            if (!Directory.Exists(rootPath)) return;

            dirManager.CreateFolders(rootPath, 100);
            dirManager.DeleteFolders(rootPath, 100);
        }
    }
}