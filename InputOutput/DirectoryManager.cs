using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class DirectoryManager
    {
        public void CreateFolders(string rootPath, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string dirPath = Path.Combine(rootPath, $"Folder_{i}");
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                    Console.WriteLine($"Создано: {dirPath}");
                }
                else
                {
                    Console.WriteLine($"{dirPath} уже существует");
                }
            }
        }

        public void DeleteFolders(string rootPath, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string dirPath = Path.Combine(rootPath, $"Folder_{i}");
                if (Directory.Exists(dirPath))
                {
                    Directory.Delete(dirPath);
                    Console.WriteLine($"Удалено: {dirPath}");
                }
                else
                {
                    Console.WriteLine($"{dirPath} уже не существует");
                }
            }
        }
    }
}
