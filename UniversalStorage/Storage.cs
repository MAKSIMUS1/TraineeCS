using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalStorage
{
    public class Storage<T>
    {
        private List<T> _items = new List<T>();
        public void AddItem(T item)
        {
            _items.Add(item);
            Console.WriteLine($"Add: {item}");
        }
        public void RemoveItem(T item)
        {
            if(_items.Remove(item))
            {
                Console.WriteLine($"Removed: {item}");
            }
            else
            {
                Console.WriteLine($"Item not found: {item}");
            }
        }
        public List<T> GetAll()
        {
            return _items;
        }
    }
}
