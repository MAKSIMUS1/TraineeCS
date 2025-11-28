using System;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace ThreadsFiles
{
    public class Program
    {
        private static readonly System.Threading.Lock _fileLock = new();
        private static readonly object _loopLock = new();
        private static int counter = 1;
        private static int threadTurn = 1;
        public static void Main(string[] args)
        {
            string resultFile = "result.txt";

            Thread threadFile1 = new Thread(() => FileWork("temp1.txt", resultFile));
            Thread threadFile2 = new Thread(() => FileWork("temp2.txt", resultFile));
            threadFile1.Start();
            threadFile2.Start();
            
            Console.WriteLine("Loop:");

            Thread loopThread1 = new Thread(() => LoopWork(1, 3));
            loopThread1.Name = "Thread 1";
            Thread loopThread2 = new Thread(() => LoopWork(2, 3));
            loopThread2.Name = "Thread 2";
            Thread loopThread3 = new Thread(() => LoopWork(3, 3));
            loopThread3.Name = "Thread 3";
            loopThread1.Start();
            loopThread2.Start();
            loopThread3.Start();

        }
        public static void FileWork(string filePath, string resultFilePath)
        {   
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                lock (_fileLock)
                {
                    File.AppendAllText(resultFilePath, line);
                }
            }
        }

        public static void LoopWork(int currentThreadTurn, int numberOfThreads)
        {
            for (int i = 0; i < 10; i++)
            {
                lock (_loopLock)
                {
                    while (threadTurn != currentThreadTurn)
                        Monitor.Wait(_loopLock);

                    Console.WriteLine($"Counter: {counter} - Thread: {Thread.CurrentThread.Name}");
                    counter++;

                    threadTurn = (threadTurn % numberOfThreads) + 1;
                    Monitor.PulseAll(_loopLock);
                }
            }
        }
    }
}