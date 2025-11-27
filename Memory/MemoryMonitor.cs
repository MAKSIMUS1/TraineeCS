using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class MemoryMonitor
    {
        private readonly long _memoryLimitBytes;
        private readonly double _warningLimit;

        public MemoryMonitor(long memoryLimitBytes, double warningLimit = 0.85)
        {
            _memoryLimitBytes = memoryLimitBytes * 1024 * 1024;
            _warningLimit = warningLimit;
        }
        public long GetManagedMemory()
        {
            return GC.GetTotalMemory(false);
        }
        public int GetObjectGeneration(object obj)
        {
            return GC.GetGeneration(obj);
        }
        public void CheckMemory(object sampleObject = null)
        {
            if(sampleObject == null)
                sampleObject = new object();

            long used = GetManagedMemory();
            double percent = (double)used / _memoryLimitBytes;

            Console.WriteLine($"ManagedHeap: { used / 1024 /1024 } MB из { _memoryLimitBytes / 1024 / 1024 } MB");
            Console.WriteLine($"Поколение sample-объекта: {GC.GetGeneration(sampleObject)}");

            if(percent >= 1)
            {
                Console.WriteLine("Превышен лимит");
            }
            else if(percent >= _warningLimit)
            {
                Console.WriteLine("Используемая память приближается к лимиту");
            }
            else
            {
                Console.WriteLine("Память в норме");
            }

        }
    }
}
