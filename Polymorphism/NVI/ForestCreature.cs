using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.NVI
{
    public abstract class ForestCreature
    {
        public void Act()
        {
            Console.WriteLine("Начало действия в лесу:");
            PerformAction();
            Console.WriteLine("Конец действия в лесу:");
        }
        protected abstract void PerformAction();
    }
}
