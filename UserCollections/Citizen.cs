using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollections
{
    abstract internal class Citizen
    {
        public string Passport { get; }

        protected Citizen(string passport)
        {
            if(string.IsNullOrEmpty(passport))
                throw new ArgumentNullException("Паспорт не может быть пустым");
            Passport = passport;
        }

        public override bool Equals(object? obj)
        {
            return obj is Citizen c && this.Passport == c.Passport;
        }

        public override int GetHashCode()
        {
            return Passport.GetHashCode();
        }
        public abstract void Info();

    }
}