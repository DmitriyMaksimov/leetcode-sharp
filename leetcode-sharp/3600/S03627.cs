namespace leetcode_sharp;

// 3627. Maximum Median Sum of Subsequences of Size 3
// https://leetcode.com/problems/maximum-median-sum-of-subsequences-of-size-3
public class S03627
{
    public long MaximumMedianSum(int[] nums)
    {
        Array.Sort(nums);

        var result = 0L;

        for (var right = nums.Length - 1; nums.Length / 3 < right; right -= 2)
        {
            result += nums[right - 1];
        }

        return result;
    }
}