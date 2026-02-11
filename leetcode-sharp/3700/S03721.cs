namespace leetcode_sharp;

// 3721. Longest Balanced Subarray II
// https://leetcode.com/problems/longest-balanced-subarray-ii
public class S03721
{
    private sealed class SegmentTree(int size)
    {
        private readonly int[] _min = new int[4 * size];
        private readonly int[] _max = new int[4 * size];
        private readonly int[] _lazy = new int[4 * size];

        public void UpdateRange(int left, int right, int value) => UpdateRange(1, 0, size - 1, left, right, value);

        public int FindLeftmostZero() => FindLeftmostZero(1, 0, size - 1);

        private void Push(int node, int start, int end)
        {
            if (_lazy[node] == 0)
            {
                return;
            }

            _min[node] += _lazy[node];
            _max[node] += _lazy[node];

            if (start != end)
            {
                _lazy[node * 2] += _lazy[node];
                _lazy[node * 2 + 1] += _lazy[node];
            }

            _lazy[node] = 0;
        }

        private void UpdateRange(int node, int start, int end, int left, int right, int value)
        {
            Push(node, start, end);

            if (start > end || start > right || end < left)
            {
                return;
            }

            if (left <= start && end <= right)
            {
                _lazy[node] += value;
                Push(node, start, end);
                return;
            }

            var mid = start + ((end - start) / 2);

            UpdateRange(node * 2, start, mid, left, right, value);
            UpdateRange(node * 2 + 1, mid + 1, end, left, right, value);

            _min[node] = Math.Min(_min[node * 2], _min[node * 2 + 1]);
            _max[node] = Math.Max(_max[node * 2], _max[node * 2 + 1]);
        }

        private int FindLeftmostZero(int node, int start, int end)
        {
            Push(node, start, end);

            if (_min[node] > 0 || _max[node] < 0)
            {
                return -1;
            }

            if (start == end)
            {
                return _min[node] == 0 ? start : -1;
            }

            var mid = start + ((end - start) / 2);

            var left = FindLeftmostZero(node * 2, start, mid);
            return left != -1
                ? left
                : FindLeftmostZero(node * 2 + 1, mid + 1, end);
        }
    }

    public int LongestBalanced(int[] nums)
    {
        var n = nums.Length;
        var previousIndex = new Dictionary<int, int>();
        var segmentTree = new SegmentTree(n);

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var value = nums[i];
            var delta = (value % 2 == 0) ? 1 : -1;

            if (previousIndex.TryGetValue(value, out var prev))
            {
                segmentTree.UpdateRange(0, prev, -delta);
            }

            segmentTree.UpdateRange(0, i, delta);
            previousIndex[value] = i;

            var left = segmentTree.FindLeftmostZero();
            if (left != -1 && left <= i)
            {
                result = Math.Max(result, i - left + 1);
            }
        }

        return result;
    }
}
