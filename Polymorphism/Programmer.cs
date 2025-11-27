using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Programmer : Worker
    {
        protected override void ComeToWork()
        {
            Console.WriteLine("Программист: пришёл в офис в 8:30");
        }

        protected override void PrepareWorkplace()
        {
            Console.WriteLine("Программист: включил компьютер, открыл IDE");
        }

        protected override void WorkBeforeLunch()
        {
            Console.WriteLine("Программист: пишет код");
        }

        protected override void Lunch()
        {
            Console.WriteLine("Программист: пошёл на обед с коллегами");
        }

        protected override void WorkAfterLunch()
        {
            Console.WriteLine("Программист: продолжает писать код, митинги");
        }

        protected override void LeaveWork()
        {
            Console.WriteLine("Программист: закончил рабочий день");
        }
    }

}
