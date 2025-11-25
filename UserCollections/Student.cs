using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollections
{
    internal class Student : Citizen
    {
        public Student(string passport) : base(passport) { }
        public override void Info() => Console.WriteLine($"Студент, Паспорт: {Passport}");
    }
}
