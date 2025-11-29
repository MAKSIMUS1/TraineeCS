using System;
using System.Text;
using System.Threading;
using static AsyncModel.AsyncExample;

namespace AsyncModel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AsyncExample ae = new AsyncExample();

            ae.RunAsync("Hello", AsyncExample.Callback);

            Console.WriteLine("Main thread continue");
            Console.ReadLine();
        }
    }
}