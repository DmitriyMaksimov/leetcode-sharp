namespace leetcode_sharp;

// 2916. Subarrays Distinct Element Sum of Squares II
// https://leetcode.com/problems/subarrays-distinct-element-sum-of-squares-ii
public class S02916
{
    private const int Mod = 1_000_000_007;

    private sealed class SegmentTreeNode(int lo, int hi)
    {
        private long _val;
        private long _lazy;
        private readonly SegmentTreeNode? _left = lo + 1 < hi ? new SegmentTreeNode(lo, (lo + hi) / 2) : null;
        private readonly SegmentTreeNode? _right = lo + 1 < hi ? new SegmentTreeNode((lo + hi) / 2, hi) : null;

        private void Update(long value)
        {
            _lazy += value;
            _val += value * (hi - lo);
        }

        public long Query(int lo1, int hi1)
        {
            if (lo >= lo1 && hi <= hi1)
            {
                var res = _val;
                Update(1);
                return res;
            }

            var mid = (lo + hi) / 2;
            long result = 0;

            _left!.Update(_lazy);
            _right!.Update(_lazy);
            _lazy = 0;

            if (lo1 < mid)
            {
                result += _left.Query(lo1, hi1);
            }

            if (hi1 > mid)
            {
                result += _right.Query(lo1, hi1);
            }

            _val = _left._val + _right._val;

            return result;
        }
    }

    public int SumCounts(int[] nums)
    {
        var lastIndex = new Dictionary<int, int>();
        var segmentTree = new SegmentTreeNode(0, nums.Length);
        var result = 0L;
        var currentResult = 0L;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var lastIdx = lastIndex.GetValueOrDefault(num, -1) + 1;

            currentResult = (currentResult + i - lastIdx + 1 + 2 * segmentTree.Query(lastIdx, i + 1)) % Mod;

            result = (result + currentResult) % Mod;
            lastIndex[num] = i;
        }

        return (int)result;
    }
}