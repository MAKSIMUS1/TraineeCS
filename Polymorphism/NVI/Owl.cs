using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.NVI
{
    public class Owl : ForestCreature
    {
        protected override void PerformAction()
        {
            Console.WriteLine("Сова сидит на дереве");
        }
    }
}
