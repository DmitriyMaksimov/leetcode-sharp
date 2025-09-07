namespace leetcode_sharp;

// 480. Sliding Window Median
// https://leetcode.com/problems/sliding-window-median
public class S00480
{
    private sealed class MedianFinder(int k)
    {
        // Max heap
        private readonly PriorityQueue<int, int> _smallerHalf = new(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        // Min heap
        private readonly PriorityQueue<int, int> _largerHalf = new();

        // Tracks numbers that should be removed later
        private readonly Dictionary<int, int> _delayedRemovals = new();

        private int _smallerHalfSize;
        private int _largerHalfSize;

        public int WindowSize { get; } = k;

        public void AddNum(int num)
        {
            if (_smallerHalf.Count == 0 || num <= Peek(_smallerHalf))
            {
                _smallerHalf.Enqueue(num, num);
                _smallerHalfSize++;
            }
            else
            {
                _largerHalf.Enqueue(num, num);
                _largerHalfSize++;
            }

            Rebalance();
        }

        public double FindMedian()
        {
            return (WindowSize & 1) == 1
                ? Peek(_smallerHalf)
                : ((long)Peek(_smallerHalf) + Peek(_largerHalf)) / 2.0;
        }

        public void RemoveNum(int num)
        {
            if (!_delayedRemovals.TryAdd(num, 1))
            {
                _delayedRemovals[num]++;
            }

            if (num <= Peek(_smallerHalf))
            {
                _smallerHalfSize--;
                if (num == Peek(_smallerHalf))
                {
                    Prune(_smallerHalf);
                }
            }
            else
            {
                _largerHalfSize--;
                if (_largerHalf.Count > 0 && num == Peek(_largerHalf))
                {
                    Prune(_largerHalf);
                }
            }

            Rebalance();
        }

        private void Prune(PriorityQueue<int, int> heap)
        {
            while (heap.Count > 0 && _delayedRemovals.ContainsKey(Peek(heap)))
            {
                var top = Peek(heap);

                if (--_delayedRemovals[top] == 0)
                {
                    _delayedRemovals.Remove(top);
                }

                heap.Dequeue();
            }
        }

        private void Rebalance()
        {
            if (_smallerHalfSize > _largerHalfSize + 1)
            {
                var moved = _smallerHalf.Dequeue();
                _largerHalf.Enqueue(moved, moved);
                _smallerHalfSize--;
                _largerHalfSize++;
                Prune(_smallerHalf);
            }
            else if (_smallerHalfSize < _largerHalfSize)
            {
                var moved = _largerHalf.Dequeue();
                _smallerHalf.Enqueue(moved, moved);
                _largerHalfSize--;
                _smallerHalfSize++;
                Prune(_largerHalf);
            }
        }

        private static int Peek(PriorityQueue<int, int> heap)
        {
            return !heap.TryPeek(out var value, out _) ? throw new InvalidOperationException("Heap is empty") : value;
        }
    }

    public double[] MedianSlidingWindow(int[] nums, int k)
    {
        var medianFinder = new MedianFinder(k);

        for (var i = 0; i < k; i++)
        {
            medianFinder.AddNum(nums[i]);
        }

        var n = nums.Length;
        var result = new double[n - k + 1];

        result[0] = medianFinder.FindMedian();

        for (var i = k; i < n; i++)
        {
            medianFinder.AddNum(nums[i]);
            medianFinder.RemoveNum(nums[i - k]);
            result[i - k + 1] = medianFinder.FindMedian();
        }

        return result;
    }
}