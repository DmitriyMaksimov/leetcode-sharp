namespace leetcode_sharp;

// 2461. Maximum Sum of Distinct Subarrays With Length K
// https://leetcode.com/problems/maximum-sum-of-distinct-subarrays-with-length-k
public class S02461
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        var result = 0L;
        var current = 0L;
        var dup = -1L;
        var pos = Enumerable.Repeat(-1, 100001).ToArray();

        for (var i = 0; i < nums.Length; ++i)
        {
            current += nums[i];
            if (i >= k)
            {
                current -= nums[i - k];
            }

            dup = Math.Max(dup, pos[nums[i]]);

            if (i - dup >= k)
            {
                result = Math.Max(result, current);
            }

            pos[nums[i]] = i;
        }

        return result;
    }
}
