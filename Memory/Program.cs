using System.Text;

namespace Memory
{
    class Program
    {
        private const long maxGarbage = 1000;

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var monitor = new MemoryMonitor(180);

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