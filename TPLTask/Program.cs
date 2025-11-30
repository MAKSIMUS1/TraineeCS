namespace TPLTask
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Главный поток продолжает работать");

            Task t1 = Task.Run(Method1);
            Task t2 = Task.Run(Method2);

            await Task.WhenAll(t1, t2);

            Console.WriteLine("Обе задачи завершены");

            // - - - - - - - - - 
            int size = 1_000_000;
            Random rnd = new Random();

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
                numbers[i] = rnd.Next(1, 1_000_000);

            var oddNumbers = numbers
                .AsParallel()
                .Where(n => n % 2 != 0)
                .ToArray();

            Console.WriteLine($"Всего нечётных чисел: {oddNumbers.Length}");
        }
        static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Метод 1 — {i + 1}");
                Task.Delay(300).Wait();
            }
        }

        static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Метод 2 — {i + 1}");
                Task.Delay(200).Wait();
            }
        }
    }
}