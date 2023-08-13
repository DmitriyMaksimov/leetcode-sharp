namespace leetcode_sharp;

public static class S00146
{
    public class LRUCache
    {
        private readonly int _capacity;
        private readonly Dictionary<int, LinkedListNode<(int key, int value)>> _cacheMap = new();
        private readonly LinkedList<(int key, int value)> _lruList = new();

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (!_cacheMap.TryGetValue(key, out var node)) return -1;

            var value = node.Value.value;
            _lruList.Remove(node);
            _lruList.AddLast(node);
            return value;
        }

        public void Put(int key, int value)
        {
            if (_cacheMap.TryGetValue(key, out var existingNode))
            {
                _lruList.Remove(existingNode);
            }
            else if (_cacheMap.Count >= _capacity)
            {
                removeFirst();
            }

            var node = new LinkedListNode<(int key, int value)>((key, value));
            _lruList.AddLast(node);
            _cacheMap[key] = node;
        }

        private void removeFirst()
        {
            // Remove from LRUPriority
            var node = _lruList.First;
            _lruList.RemoveFirst();

            // Remove from cache
            _cacheMap.Remove(node.Value.key);
        }
    }
}