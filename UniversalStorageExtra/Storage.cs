using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalStorageExtra
{
    public class Storage<T>
    {
        private T[] _items;
        private int _index = 0;

        public Storage(int size)
        {
            _items = new T[size];
        }
        public void Add(T item)
        {
            if(_index < _items.Length)
            {
                _items[_index] = item;
                _index++;
            }
            else 
            {
                Console.WriteLine("Storage full");
            }
        }

        public T Get(int index)
        {
            if (index >= 0 && index < _index)
            {
                return _items[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

        }
    }
}
