using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class FileManager
    {
        public List<string> FindFiles(string sourceDirectory, string fileName)
        {
            var result = new List<string>();
            try
            {
                var files = Directory.EnumerateFiles(sourceDirectory, fileName, SearchOption.AllDirectories);
                result.AddRange(files);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Нет доступа к некоторым папкам.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public void ReadFile(string filePath)
        {
            try
            {
                using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using StreamReader reader = new StreamReader(fs, Encoding.UTF8);
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка чтения файла: {ex.Message}");
            }
        }

        public void CompressFile(string filePath)
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
