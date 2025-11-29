using System.Text;

namespace Memory
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введите порог памяти в МБ: ");
            int limitMb;
            while (!int.TryParse(Console.ReadLine(), out limitMb) || limitMb <= 0)
            {
                Console.Write("Некорректный ввод. Введите положительное число: ");
            }

            var monitor = new MemoryMonitor(limitMb);

            int[] bigArray = new int[5_000_000];

            monitor.CheckMemory(bigArray);
            using (var obj = new SomeGarbageObject(150))
            {
                monitor.CheckMemory(bigArray);
            }

            GC.Collect();

            monitor.CheckMemory();
        }
    }
}