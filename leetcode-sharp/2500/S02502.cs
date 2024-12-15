namespace leetcode_sharp;

// 2502. Design Memory Allocator
// https://leetcode.com/problems/design-memory-allocator
public static class S02502
{
    public class Allocator
    {
        private readonly Dictionary<int, List<(int start, int size)>> _allocations;
        private readonly SortedDictionary<int, int> _availableBlocks;

        public Allocator(int n)
        {
            _allocations = new Dictionary<int, List<(int, int)>>();
            _availableBlocks = new SortedDictionary<int, int> { { 0, n } };
        }

        public int Allocate(int size, int id)
        {
            foreach (var (start, blockSize) in _availableBlocks)
            {
                if (blockSize < size)
                {
                    continue;
                }

                _allocations.TryAdd(id, []);
                _allocations[id].Add((start: start, size));

                _availableBlocks.Remove(start);

                if (blockSize > size)
                {
                    _availableBlocks[start + size] = blockSize - size;
                }

                return start;
            }

            return -1;
        }

        public int FreeMemory(int id)
        {
            if (!_allocations.TryGetValue(id, out var blocks))
            {
                return 0;
            }

            var releasedMemory = 0;

            foreach (var (start, size) in blocks)
            {
                var localStart = start;
                releasedMemory += size;

                _availableBlocks.TryAdd(start, size);

                var prevKey = _availableBlocks.Keys.Count > 0 ? GetPreviousKey(start) : -1;

                if (prevKey != -1 && prevKey + _availableBlocks[prevKey] == start)
                {
                    _availableBlocks[prevKey] += size;
                    _availableBlocks.Remove(start);
                    localStart = prevKey;
                }

                var nextKey = GetNextKey(localStart);
                if (nextKey != -1 && localStart + _availableBlocks[localStart] == nextKey)
                {
                    _availableBlocks[localStart] += _availableBlocks[nextKey];
                    _availableBlocks.Remove(nextKey);
                }
            }

            _allocations.Remove(id);

            return releasedMemory;
        }

        private int GetPreviousKey(int key)
        {
            var prevKey = -1;

            foreach (var k in _availableBlocks.Keys.TakeWhile(k => k < key))
            {
                prevKey = k;
            }

            return prevKey;
        }

        private int GetNextKey(int key)
        {
            foreach (var k in _availableBlocks.Keys.Where(k => k > key))
            {
                return k;
            }

            return -1;
        }
    }
}
