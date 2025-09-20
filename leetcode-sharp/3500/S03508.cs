namespace leetcode_sharp;

// 3508. Implement Router
// https://leetcode.com/problems/implement-router
public class S03508
{
    public class Router
    {
        private readonly int _memoryLimit;
        private readonly Queue<Packet> _queue;
        private readonly HashSet<PacketKey> _set = [];
        private readonly Dictionary<int, List<int>> _destTimestamps = new();
        private readonly Dictionary<int, int> _processedIndex = new();

        public Router(int memoryLimit)
        {
            _memoryLimit = memoryLimit;
            _queue = new Queue<Packet>(memoryLimit);
        }

        public bool AddPacket(int source, int destination, int timestamp)
        {
            var key = new PacketKey(source, destination, timestamp);
            if (_set.Contains(key))
            {
                return false;
            }

            if (_queue.Count == _memoryLimit)
            {
                EvictOldest();
            }

            var packet = new Packet(source, destination, timestamp);
            _queue.Enqueue(packet);
            _set.Add(key);

            if (!_destTimestamps.TryGetValue(destination, out var list))
            {
                list = [];
                _destTimestamps[destination] = list;
                _processedIndex[destination] = 0;
            }

            list.Add(timestamp);

            return true;
        }

        public int[] ForwardPacket()
        {
            if (_queue.Count == 0)
            {
                return [];
            }

            var oldest = _queue.Dequeue();
            _set.Remove(new PacketKey(oldest.Source, oldest.Destination, oldest.Timestamp));
            _processedIndex[oldest.Destination]++;

            return [oldest.Source, oldest.Destination, oldest.Timestamp];
        }

        public int GetCount(int destination, int startTime, int endTime)
        {
            if (!_destTimestamps.TryGetValue(destination, out var list))
            {
                return 0;
            }

            var startIndex = _processedIndex[destination];
            var n = list.Count;
            if (startIndex >= n)
            {
                return 0;
            }

            var left = LowerBound(list, startIndex, n, startTime);
            var right = UpperBound(list, startIndex, n, endTime);

            return right - left;
        }

        private void EvictOldest()
        {
            var oldest = _queue.Dequeue();
            _set.Remove(new PacketKey(oldest.Source, oldest.Destination, oldest.Timestamp));
            _processedIndex[oldest.Destination]++;
        }

        private static int LowerBound(List<int> list, int left, int right, int target)
        {
            var lo = left;
            var hi = right;

            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;

                if (list[mid] < target)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid;
                }
            }

            return lo;
        }

        private static int UpperBound(List<int> list, int left, int right, int target)
        {
            var lo = left;
            var hi = right;

            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
            
                if (list[mid] <= target)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid;
                }
            }

            return lo;
        }

        private record Packet(int Source, int Destination, int Timestamp);
        private record PacketKey(int Source, int Destination, int Timestamp);
    }
}