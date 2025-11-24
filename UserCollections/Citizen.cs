using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollections
{
    abstract internal class Citizen
    {
        private string _passport;
        public string Passport
        {
            get => _passport;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Паспорт не может быть пустым");
                _passport = value;
            }
        }

        protected Citizen(string passport)
        {
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