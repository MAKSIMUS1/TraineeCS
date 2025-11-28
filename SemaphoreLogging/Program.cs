using System;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace SemaphoreLogging
{
    public class Program
    {
        private static readonly Semaphore _semaphorePool = new Semaphore(2, 2);
        private static readonly Lock _logLock= new();
        private static string _logFile = "log.txt";
        public static void Main(string[] args)
        {
            string logFile = "log.txt";

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(() => Worker());
                thread.Name = "Thread_" + i;
                thread.Start();
            }

        }

        private static void Worker()
        {
            Log($"Thread {Thread.CurrentThread.Name} begins and wait semaphore\n");
            _semaphorePool.WaitOne();
            Log($"Thread {Thread.CurrentThread.Name} enters semaphore\n");
            Log($"Thread {Thread.CurrentThread.Name} releases the semaphore\n");
            Log($"Thread {Thread.CurrentThread.Name} previous semaphore count: {_semaphorePool.Release()}\n");
        }

        private static void Log(string message)
        {
            lock(_logLock)
            {
                File.AppendAllText(_logFile, message);
            }
        }
    }
}