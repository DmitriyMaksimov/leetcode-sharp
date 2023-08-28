namespace leetcode_sharp;

// 303. Range Sum Query - Immutable
// https://leetcode.com/problems/range-sum-query-immutable/
public static class S00303
{
    public class NumArray
    {
        private readonly int[] _preSum;

        public NumArray(int[] nums)
        {
            _preSum = nums;
            for (var i = 1; i < _preSum.Length; ++i)
            {
                _preSum[i] += _preSum[i - 1];
            }
        }

        public int SumRange(int left, int right)
        {
            return left == 0 ? _preSum[right] : _preSum[right] - _preSum[left - 1];
        }
    }
}