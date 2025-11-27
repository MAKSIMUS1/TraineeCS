using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Worker
    {
        public void WorkDay()
        {
            ComeToWork();
            PrepareWorkplace();
            WorkBeforeLunch();
            Lunch();
            WorkAfterLunch();
            LeaveWork();
        }
        protected abstract void ComeToWork();
        protected abstract void PrepareWorkplace();
        protected abstract void WorkBeforeLunch();
        protected abstract void Lunch();
        protected abstract void WorkAfterLunch();
        protected abstract void LeaveWork();
    }
}
