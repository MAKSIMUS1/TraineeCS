using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public static class ReflectionInfo
    {
        public static void GetReflectionInformation(Assembly assembly)
        {
            if(assembly == null)
            {
                Console.WriteLine("Сборка не загружена");
                return;
            }

            Console.WriteLine($"Сборка: {assembly.FullName}");
            foreach(var type in assembly.GetTypes())
            {
                Console.WriteLine($"Класс: {type.FullName}");
                var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach(var method in methods)
                {
                    string staticFlag = method.IsStatic ? "(static)" : "";
                    Console.WriteLine($"Метод: {method.Name} {staticFlag}");
                }

                var properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var prop in properties)
                {
                    Console.WriteLine($"Свойство: {prop.Name}");
                }
                
                var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var field in fields)
                {
                    Console.WriteLine($"Поле: {field.Name}");
                }
            }
        }
    }
}
