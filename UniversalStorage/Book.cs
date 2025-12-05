using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalStorage
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"Book: {Title} by {Author}";
        }
    }
}
