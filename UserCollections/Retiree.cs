using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollections
{
    internal class Retiree : Citizen
    {
        public Retiree(string passport) : base(passport) { }

        public override void Info() => Console.WriteLine($"Пенсионер, Паспорт: {Passport}");
    }
}
