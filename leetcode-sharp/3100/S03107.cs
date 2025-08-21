namespace leetcode_sharp;

// 3107. Minimum Operations to Make Median of Array Equal to K
// https://leetcode.com/problems/minimum-operations-to-make-median-of-array-equal-to-k 
public class S03107
{
    public long MinOperationsToMakeMedianK(int[] nums, int k)
    {
        Array.Sort(nums);

        var result = 0L;

        for (var i = 0; i <= nums.Length / 2; ++i)
        {
            result += Math.Max(0, nums[i] - k);
        }

        for (var i = nums.Length / 2; i < nums.Length; ++i)
        {
            result += Math.Max(0, k - nums[i]);
        }

        return result;
    }
}