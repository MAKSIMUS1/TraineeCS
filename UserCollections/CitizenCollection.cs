using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace UserCollections
{
    internal class CitizenCollection : IEnumerable
    {
        private ArrayList _items = new ArrayList();
        public int Add(Citizen citizen)
        {
            if (citizen == null)
                throw new ArgumentNullException(nameof(citizen));
            int numberInQueue = 0;

            bool passportExists = _items.Contains(citizen);
            if (passportExists)
            {
                Console.WriteLine("Добавление человека с повторным паспортом невозможно");
                return -1;
            }

            if (citizen is Retiree)
            {
                int lastIndex = -1;
                for (int i = 0; i < _items.Count; i++)
                {
                    if (_items[i] is Retiree)
                    {
                        lastIndex = i;
                    }
                }
                _items.Insert(lastIndex + 1, citizen);
                numberInQueue = lastIndex + 2;
            }
            else
            {
                _items.Add(citizen);
                numberInQueue = _items.Count;
            }
            return numberInQueue;
        }

        public void Remove()
        {
            if (_items.Count > 0)
            {
                _items.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Коллекция пустая");
            }
        }
        public void Remove(Citizen citizen)
        {
            _items.Remove(citizen);
        }

        public bool Contains(Citizen citizen)
        {
            return _items.Contains(citizen);
        }

        public Citizen ReturnLast()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return null;
            }

            Citizen last = (Citizen)_items[_items.Count - 1];
            return last;
        }
        public void Clear()
        {
            _items.Clear();
        }
        public IEnumerator GetEnumerator() => _items.GetEnumerator();

    }
}