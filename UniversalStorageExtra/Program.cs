namespace UniversalStorageExtra
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Storage<T> Example ===");

            Storage<int> intStorage = new Storage<int>(3);
            intStorage.Add(10);
            intStorage.Add(20);
            intStorage.Add(30);

            Console.WriteLine($"Item 0: {intStorage.Get(0)}");
            Console.WriteLine($"Item 1: {intStorage.Get(1)}");
            Console.WriteLine($"Item 2: {intStorage.Get(2)}");

            Console.WriteLine("\n=== Swap<T> Example ===");

            int a = 5, b = 10;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            Helper.Swap(ref a, ref b);
            Console.WriteLine($"After swap:  a = {a}, b = {b}");

            Console.WriteLine("\n=== List<T> Example ===");

            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine("\n=== Dictionary<TKey, TValue> Example ===");

            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(1, "Admin");
            users.Add(2, "Manager");
            users.Add(3, "Guest");

            foreach (var pair in users)
                Console.WriteLine($"ID: {pair.Key}, Role: {pair.Value}");
        }
    }
}