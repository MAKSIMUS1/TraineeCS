using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalStorage
{
    public static class Helper
    {
        public static T FindItem<T>(IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach(var item in collection)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }
    }
}
