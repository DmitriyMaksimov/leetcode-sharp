namespace leetcode_sharp;

// 1749. Maximum Absolute Sum of Any Subarray
// https://leetcode.com/problems/maximum-absolute-sum-of-any-subarray
public class S01749
{
    public int MaxAbsoluteSum(int[] nums)
    {
        var res = 0;
        var maxSum = 0;
        var minSum = 0;

        foreach (var num in nums)
        {
            maxSum = Math.Max(0, num + maxSum);
            minSum = Math.Min(0, num + minSum);
            res = Math.Max(res, Math.Max(maxSum, -minSum));
        }

        return res;
    }
}
