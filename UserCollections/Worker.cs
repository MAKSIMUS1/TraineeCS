using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollections
{
    internal class Worker : Citizen
    {
        public Worker(string passport) : base(passport) { }
        public override void Info() => Console.WriteLine($"Работник, Паспорт: {Passport}");
    }
}
