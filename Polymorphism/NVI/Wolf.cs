using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.NVI
{
    public class Wolf : ForestCreature
    {
        protected override void PerformAction()
        {
            Console.WriteLine("Волк ищет добычу");
        }
    }
}
