using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cook : Worker
    {
        protected override void ComeToWork()
        {
            Console.WriteLine("Повар: пришёл на кухню в 6:30 утра");
        }

        protected override void PrepareWorkplace()
        {
            Console.WriteLine("Повар: проверяет продукты");
        }

        protected override void WorkBeforeLunch()
        {
            Console.WriteLine("Повар: готовит блюда");
        }

        protected override void Lunch()
        {
            Console.WriteLine("Повар: перекусывает");
        }

        protected override void WorkAfterLunch()
        {
            Console.WriteLine("Повар: готовит обеды");
        }

        protected override void LeaveWork()
        {
            Console.WriteLine("Повар: убирает кухню и уходит домой");
        }
    }

}
