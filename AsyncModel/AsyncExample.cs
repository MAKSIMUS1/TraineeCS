using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncModel
{
    public class AsyncExample
    {
        public string TestWork(string input)
        {
            Console.WriteLine("TestWork start");
            Thread.Sleep(500);
            var threadId = Thread.CurrentThread.ManagedThreadId;
            return $"Processed '{input}' on thread {threadId}";
        }

        public void RunAsync(string input, Action<string> callback)
        {
            Task.Run(() =>
            {
                string result = TestWork(input);
                return result;
            })
            .ContinueWith(task =>
            {
                callback(task.Result);
            });
        }

        public static void Callback(string result)
        {
            Console.WriteLine("Callback received result:");
            Console.WriteLine(result);
        }
    }
}
