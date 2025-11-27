namespace leetcode_sharp;

// 3381. Maximum Subarray Sum With Length Divisible by K
// https://leetcode.com/problems/maximum-subarray-sum-with-length-divisible-by-k
public class S03381
{
    public long MaxSubarraySum(int[] nums, int k)
    {
        var prefixSum = 0L;
        var result = long.MinValue;
        var minSoFar = Enumerable.Repeat(long.MaxValue / 2, k).ToArray();

        minSoFar[(k - 1) % k] = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];

            var index = i % k;

            result = Math.Max(result, prefixSum - minSoFar[index]);
            minSoFar[index] = Math.Min(minSoFar[index], prefixSum);
        }

        return result;
    }
}