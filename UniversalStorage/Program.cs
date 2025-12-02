namespace UniversalStorage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bookStorage = new Storage<Book>();
            var phoneStorage = new Storage<Phone>();
            var fruitStorage = new Storage<Fruit>();

            bookStorage.AddItem(new Book { Title = "1984", Author = "George Orwell" });
            bookStorage.AddItem(new Book { Title = "C# in Depth", Author = "Jon Skeet" });

            phoneStorage.AddItem(new Phone { Model = "iPhone 14", Price = 999 });
            phoneStorage.AddItem(new Phone { Model = "Samsung Galaxy S23", Price = 899 });
            phoneStorage.AddItem(new Phone { Model = "Nokia 3310", Price = 99 });

            fruitStorage.AddItem(new Fruit { Name = "Apple", Weight = 0.200 });
            fruitStorage.AddItem(new Fruit { Name = "Banana", Weight = 0.250 });
            fruitStorage.AddItem(new Fruit { Name = "Potato", Weight = 0.750 });

            Console.WriteLine("\nAll books:");
            foreach (var book in bookStorage.GetAll())
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nAll phones:");
            foreach (var phone in phoneStorage.GetAll())
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine("\nAll fruits:");
            foreach (var fruit in fruitStorage.GetAll())
            {
                Console.WriteLine(fruit);
            }


            var foundBook = Helper.FindItem(bookStorage.GetAll(), b => b.Author == "Jon Skeet");
            Console.WriteLine($"\nFound book by Jon Skeet: {foundBook}");

            var foundPhone = Helper.FindItem(phoneStorage.GetAll(), p => p.Price < 950);
            Console.WriteLine($"Found phone under $950: {foundPhone}");

            var foundFruit = Helper.FindItem(fruitStorage.GetAll(), f => f.Name == "Banana");
            Console.WriteLine($"Found fruit: {foundFruit}");
        }
    }
}