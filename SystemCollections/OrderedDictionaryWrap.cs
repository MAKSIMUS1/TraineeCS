using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCollections
{
    public class OrderedDictionaryWrap<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private readonly List<TKey> _keys = new();
        private readonly List<TValue> _values = new();

        private readonly IComparer<TKey> _keyComparer;

        public OrderedDictionaryWrap(IComparer<TKey> comparer = null!)
        {
            _keyComparer = comparer ?? Comparer<TKey>.Default;
        }

        public void Add(TKey key, TValue value)
        {
            for(int i = 0; i < _keys.Count; i++)
            {
                if (_keyComparer.Compare(_keys[i], key) == 0)
                    throw new ArgumentException("Ключ уже существует");
            }
            _keys.Add(key);
            _values.Add(value);
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < _keys.Count; i++)
                yield return new KeyValuePair<TKey, TValue>(_keys[i], _values[i]);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
