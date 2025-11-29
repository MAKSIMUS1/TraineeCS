using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionWithAttributes
{
    public static class ReflectionWAttributes
    {
        private static readonly BindingFlags Flags =
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly;
        public static void GetReflectionInformation(Assembly assembly)
        {
            if (assembly == null)
            {
                Console.WriteLine("Сборка не загружена.");
                return;
            }

            Console.WriteLine($"\nЗагруженная сборка:\n{assembly.FullName}\n");

            Console.WriteLine("Выберите, что вывести:");
            Console.WriteLine("1 — Методы");
            Console.WriteLine("2 — Свойства");
            Console.WriteLine("3 — Поля");
            Console.WriteLine("4 — Конструкторы");
            Console.WriteLine("5 — События");
            Console.WriteLine("0 — Всё");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            foreach (Type type in assembly.GetTypes())
            {
                Console.WriteLine($"\nТип: {type.FullName}");

                PrintAttributes(type.GetCustomAttributes(), "Атрибуты типа");

                if (choice == "1" || choice == "0") PrintMethods(type);
                if (choice == "2" || choice == "0") PrintProperties(type);
                if (choice == "3" || choice == "0") PrintFields(type);
                if (choice == "4" || choice == "0") PrintConstructors(type);
                if (choice == "5" || choice == "0") PrintEvents(type);
            }
        }

        private static void PrintMethods(Type type)
        {
            Console.WriteLine("\n  Методы:");
            MethodInfo[] methods = type.GetMethods(Flags);

            foreach (var m in methods)
            {
                string mod = m.IsStatic ? "static" : "instance";
                Console.WriteLine($"    {m.Name} ({mod})");

                PrintAttributes(m.GetCustomAttributes(), "        Атрибуты метода");
            }
        }

        private static void PrintProperties(Type type)
        {
            Console.WriteLine("\n  Свойства:");
            var props = type.GetProperties(Flags);

            foreach (var p in props)
            {
                Console.WriteLine($"    {p.Name} : {p.PropertyType.Name}");
                PrintAttributes(p.GetCustomAttributes(), "        Атрибуты свойства");
            }
        }

        private static void PrintFields(Type type)
        {
            Console.WriteLine("\n  Поля:");
            var fields = type.GetFields(Flags);

            foreach (var f in fields)
            {
                Console.WriteLine($"    {f.Name} : {f.FieldType.Name}");
                PrintAttributes(f.GetCustomAttributes(), "        Атрибуты поля");
            }
        }

        private static void PrintConstructors(Type type)
        {
            Console.WriteLine("\n  Конструкторы:");
            var constructors = type.GetConstructors(Flags);

            foreach (var c in constructors)
            {
                Console.WriteLine($"    {c.Name} (параметров: {c.GetParameters().Length})");
                PrintAttributes(c.GetCustomAttributes(), "        Атрибуты конструктора");
            }
        }

        private static void PrintEvents(Type type)
        {
            Console.WriteLine("\n  События:");
            var events = type.GetEvents(Flags);

            foreach (var e in events)
            {
                Console.WriteLine($"    {e.Name}");
                PrintAttributes(e.GetCustomAttributes(), "        Атрибуты события");
            }
        }
        private static void PrintAttributes(IEnumerable<object> attributes, string header)
        {
            foreach (var attr in attributes)
            {
                Console.WriteLine($"{header}: {attr.GetType().Name}");
            }
        }
    }
}
