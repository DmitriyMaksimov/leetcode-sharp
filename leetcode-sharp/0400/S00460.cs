using System.Collections;

namespace leetcode_sharp;

public class S00460
{
    public class LFUCache
    {
        public class OrderedSet<T> : ICollection<T> where T : notnull
        {
            private readonly IDictionary<T, LinkedListNode<T>> _dictionary;
            private readonly LinkedList<T> _linkedList;

            public OrderedSet()
                : this(EqualityComparer<T>.Default)
            {
            }

            public OrderedSet(IEqualityComparer<T> comparer)
            {
                _dictionary = new Dictionary<T, LinkedListNode<T>>(comparer);
                _linkedList = new LinkedList<T>();
            }

            public int Count => _dictionary.Count;

            public virtual bool IsReadOnly => _dictionary.IsReadOnly;

            void ICollection<T>.Add(T item)
            {
                Add(item);
            }

            public bool Add(T item)
            {
                if (_dictionary.ContainsKey(item)) return false;
                var node = _linkedList.AddLast(item);
                _dictionary.Add(item, node);
                return true;
            }

            public void Clear()
            {
                _linkedList.Clear();
                _dictionary.Clear();
            }

            public bool Remove(T item)
            {
                if (item == null) return false;
                var found = _dictionary.TryGetValue(item, out var node);
                if (!found) return false;
                _dictionary.Remove(item);
                _linkedList.Remove(node);
                return true;
            }

            public IEnumerator<T> GetEnumerator()
            {
                return _linkedList.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public bool Contains(T item)
            {
                return item != null && _dictionary.ContainsKey(item);
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                _linkedList.CopyTo(array, arrayIndex);
            }
        }

        private readonly int _capacity;

        // key: original key, value: frequency and original value.
        private readonly Dictionary<int, (int, int)> _cache = new();

        // key: frequency, value: All keys that have the same frequency.
        private readonly Dictionary<int, OrderedSet<int>> _frequencies = new();
        private int _minFreq;

        private void insert(int key, int frequency, int value)
        {
            _cache[key] = (frequency, value);
            if (!_frequencies.ContainsKey(frequency))
            {
                _frequencies[frequency] = new OrderedSet<int>();
            }
            _frequencies[frequency].Add(key);
        }

        public int Get(int key)
        {
            if (!_cache.TryGetValue(key, out var frequencyAndValue))
            {
                return -1;
            }

            var frequency = frequencyAndValue.Item1;
            var keys = _frequencies[frequency];
            keys.Remove(key);
            if (_minFreq == frequency && !keys.Any())
            {
                ++_minFreq;
            }

            var value = frequencyAndValue.Item2;
            insert(key, frequency + 1, value);
            return value;
        }

        public void Put(int key, int value)
        {
            if (_capacity <= 0)
            {
                return;
            }

            if (_cache.TryGetValue(key, out var frequencyAndValue))
            {
                _cache[key] = (frequencyAndValue.Item1, value);
                Get(key);
                return;
            }

            if (_capacity == _cache.Count)
            {
                var keys = _frequencies[_minFreq];
                int keyToDelete = keys.First();     // Or last?
                _cache.Remove(keyToDelete);
                keys.Remove(keyToDelete);
            }

            _minFreq = 1;
            insert(key, 1, value);
        }

        public LFUCache(int capacity)
        {
            _capacity = capacity;
        }
    }
}