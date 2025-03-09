namespace leetcode_sharp;

// 3427. Sum of Variable Length Subarrays
// https://leetcode.com/problems/sum-of-variable-length-subarrays
public class S03427
{
    public int SubarraySum(int[] nums)
    {
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var start = Math.Max(0, i - nums[i]);
            result += nums.Skip(start).Take(i + 1 - start).Sum();
        }

        return result;
    }
}
