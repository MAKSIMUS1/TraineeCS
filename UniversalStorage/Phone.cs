using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalStorage
{
    public class Phone
    {
        public string Model;
        public double Price;
        public override string ToString()
        {
            return $"Phone: {Model}, Price: ${Price}";
        }
    }
}
