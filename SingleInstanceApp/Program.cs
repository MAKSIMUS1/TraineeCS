using System;
using System.Threading;

namespace SingleInstanceApp
{
    public class Program
    {
        private static readonly string _mutexName = @"Global\SingleInstanceApp";

        public static void Main(string[] args)
        {
            using Mutex mutex = new Mutex(false, _mutexName, out bool isNewInstance);

            if (!isNewInstance)
            {
                Console.WriteLine("App already started. Press smth");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Launched");
            Console.WriteLine("Press smth");
            Console.ReadLine();
        }
    }
}
