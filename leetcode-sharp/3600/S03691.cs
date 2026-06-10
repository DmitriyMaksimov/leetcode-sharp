using System.Numerics;

namespace leetcode_sharp;

// 3691. Maximum Total Subarray Value II
// https://leetcode.com/problems/maximum-total-subarray-value-ii
public class S03691
{
    private sealed class SparseTable
    {
        private readonly int[][] _min;
        private readonly int[][] _max;
        private readonly int[] _log;

        public SparseTable(IReadOnlyList<int> values)
        {
            var n = values.Count;
            var maxLog = BitOperations.Log2((uint)n) + 1;

            _min = new int[n][];
            _max = new int[n][];

            for (var i = 0; i < n; i++)
            {
                _min[i] = new int[maxLog];
                _max[i] = new int[maxLog];
            }

            _log = new int[n + 1];

            for (var i = 2; i <= n; i++)
            {
                _log[i] = _log[i / 2] + 1;
            }

            for (var i = 0; i < n; i++)
            {
                _min[i][0] = values[i];
                _max[i][0] = values[i];
            }

            for (var j = 1; (1 << j) <= n; j++)
            {
                for (var i = 0; i + (1 << j) <= n; i++)
                {
                    _min[i][j] = Math.Min(_min[i][j - 1], _min[i + (1 << (j - 1))][j - 1]);
                }
            }

            for (var j = 1; (1 << j) <= n; j++)
            {
                for (var i = 0; i + (1 << j) <= n; i++)
                {
                    _max[i][j] = Math.Max(_max[i][j - 1], _max[i + (1 << (j - 1))][j - 1]);
                }
            }
        }

        public int QueryMin(int left, int right)
        {
            var j = _log[right - left + 1];

            return Math.Min(_min[left][j], _min[right - (1 << j) + 1][j]);
        }

        public int QueryMax(int left, int right)
        {
            var j = _log[right - left + 1];

            return Math.Max(_max[left][j], _max[right - (1 << j) + 1][j]);
        }
    }

    private readonly record struct Segment(int Value, int Left, int Right);

    public long MaxTotalValue(int[] nums, int k)
    {
        var n = nums.Length;

        var st = new SparseTable(nums);

        // Max heap (larger Value dequeued first)
        var pq = new PriorityQueue<Segment, int>();

        for (var i = 0; i < n; i++)
        {
            var value = st.QueryMax(0, i) - st.QueryMin(0, i);
            pq.Enqueue(new Segment(value, 0, i), -value);
        }

        var result = 0L;

        while (k-- > 0)
        {
            var current = pq.Dequeue();

            result += current.Value;

            if (current.Left + 1 <= current.Right)
            {
                var newLeft = current.Left + 1;
                var newValue = st.QueryMax(newLeft, current.Right) - st.QueryMin(newLeft, current.Right);

                pq.Enqueue(new Segment(newValue, newLeft, current.Right), -newValue);
            }
        }

        return result;
    }
}