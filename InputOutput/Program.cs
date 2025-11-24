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
            Console.Write("Введите имя файла: ");
            var fileName = Console.ReadLine();

            Console.WriteLine("Введите путь до файла: ");
            var filePath = Console.ReadLine();

            if (!Directory.Exists(filePath))
            {
                Console.WriteLine("Такого пути нет");
                return;
            }

            Console.WriteLine("Попытка найти файл");
            var files = FindFile(filePath, fileName);

            if (files == null)
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            Console.WriteLine("Найдено:");
            foreach (var file in files) 
            { 
                Console.WriteLine("\n--- Содержимое файла ---");
                Console.WriteLine($"{file}");
                ReadFile(file);
            }

            foreach (var file in files)
            {
                Console.WriteLine($"\nСжать файл({file})? (y/n)");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    CompressFile(file);
                }
            }

            // Task extra
            var rootPath = @"F:\temp";

            if (!Directory.Exists(rootPath))
            {
                return;
            }
            
            Console.WriteLine("Создание 100 папок");

            for(int i = 0; i < 100; i ++)
            {
                string dirPath = Path.Combine(rootPath, $"Folder_{i}");

                if(!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine($"Создано: {dirPath}");
                }
                else
                {
                    Console.WriteLine($"{dirPath} уже существует");
                }
            }

            Console.WriteLine("Удаление 100 папок");

            for(int i = 0; i < 100; i++)
            {
                string dirPath = Path.Combine(rootPath, $"Folder_{i}");

                if (Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine($"Удаленно: {dirPath}");
                }
                else
                {
                    Console.WriteLine($"{dirPath} уже не существует");
                }
            }


        }

        private static List<string> FindFile(string sourceDirectory, string fileName)
        {
            var result = new List<string>();
            try
            {
                var files = Directory.EnumerateFiles(sourceDirectory, fileName, SearchOption.AllDirectories);

                foreach (string currentFile in files)
                {
                    result.Add(currentFile);
                }
            }
            catch (UnauthorizedAccessException)
            {
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        private static void ReadFile(string filePath)
        {
            try
            {
                using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using StreamReader reader = new StreamReader(fs, Encoding.UTF8);

                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка чтения файла: {ex.Message}");
            }
        }

        private static void CompressFile(string filePath)
        {
            string compressedPath = filePath + ".gz";

            try
            {
                using FileStream original = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using FileStream compressed = new FileStream(compressedPath, FileMode.Create);
                using GZipStream gzip = new GZipStream(compressed, CompressionMode.Compress);

                original.CopyTo(gzip);

                Console.WriteLine($"Файл успешно сжат: {compressedPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сжатии: {ex.Message}");
            }
        }
    }
}