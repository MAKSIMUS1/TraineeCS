using System.Threading.Channels;

namespace ReworkTask11WithAsyncAwait
{
    public class Program
    {
        private static readonly SemaphoreSlim[] semaphores =
        {
            new SemaphoreSlim(1, 1),
            new SemaphoreSlim(0, 1),
            new SemaphoreSlim(0, 1)
        };
        private static int counter = 1;
        public static async Task Main(string[] args)
        {

            var loopTask1 = LoopWorkAsync(0, "Thread 1");
            var loopTask2 = LoopWorkAsync(1, "Thread 2");
            var loopTask3 = LoopWorkAsync(2, "Thread 3");

            await Task.WhenAll(loopTask1, loopTask2, loopTask3);

        }
        public static async Task LoopWorkAsync(int myTurn, string name)
        {
            for (int i = 0; i < 10; i++)
            {
                await semaphores[myTurn].WaitAsync();

                Console.WriteLine($"Counter: {counter} - Thread: {name}");
                counter++;

                semaphores[(myTurn + 1) % 3].Release();
            }
        }
    }
}