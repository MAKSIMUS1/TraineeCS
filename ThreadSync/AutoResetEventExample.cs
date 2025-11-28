using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSync
{
    public static class AutoResetEventExample
    {

        private static AutoResetEvent _are = new AutoResetEvent(false);
        public static void Example()
        {
            Thread t3 = new Thread(ThreadProc3);
            t3.Name = "Thread_3";
            t3.Start();

            Thread t4 = new Thread(ThreadProc4);
            t4.Name = "Thread_4";
            t4.Start();
        }
        private static void ThreadProc3()
        {
            string name = Thread.CurrentThread.Name;

            Console.WriteLine($"{name} starts and calls mre.WaitOne()");

            _are.WaitOne();

            Console.WriteLine($"{name} ends");
        }
        private static void ThreadProc4()
        {
            string name = Thread.CurrentThread.Name;

            Console.WriteLine($"{name} starts");
            Thread.Sleep(1500);

            Console.WriteLine($"{name} mre.Set()");
            _are.Set();

            Console.WriteLine($"{name} ends");

        }
    }
}
