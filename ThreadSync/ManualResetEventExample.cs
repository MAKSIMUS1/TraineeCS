using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSync
{
    public static class ManualResetEventExample
    {
        private static ManualResetEvent _mre = new ManualResetEvent(false);
        public static void Example()
        {
            Thread t1 = new Thread(ThreadProc1);
            t1.Name = "Thread_1";
            t1.Start();

            Thread t2 = new Thread(ThreadProc2);
            t2.Name = "Thread_2";
            t2.Start();
        }
        private static void ThreadProc1()
        {
            string name = Thread.CurrentThread.Name;

            Console.WriteLine($"{name} starts and calls mre.WaitOne()");

            _mre.WaitOne();

            Console.WriteLine($"{name} ends");
        }
        private static void ThreadProc2()
        {
            string name = Thread.CurrentThread.Name;

            Console.WriteLine($"{name} starts");
            Thread.Sleep(1500);

            Console.WriteLine($"{name} mre.Set()");
            _mre.Set();

            Thread.Sleep(1000);
            Console.WriteLine($"{name} mre.Reset()");
            _mre.Reset();

            Console.WriteLine($"{name} ends");
        }
    }
}
