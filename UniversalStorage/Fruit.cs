using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalStorage
{
    public class Fruit
    {
        public string Name;
        public double Weight;
        public override string ToString()
        {
            return $"Fruit: {Name}, Weight: {Weight}kg";
        }
    }
}
