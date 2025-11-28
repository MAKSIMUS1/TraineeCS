using System;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace ThreadSync
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ManualResetEventExample.Example();

            Thread.Sleep(5000);

            AutoResetEventExample.Example();
        }
    }
}