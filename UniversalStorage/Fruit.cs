using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalStorage
{
    public class Fruit
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public override string ToString()
        {
            return $"Fruit: {Name}, Weight: {Weight}kg";
        }
    }
}
