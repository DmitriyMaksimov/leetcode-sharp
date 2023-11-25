namespace leetcode_sharp;

// 1685. Sum of Absolute Differences in a Sorted Array
// https://leetcode.com/problems/sum-of-absolute-differences-in-a-sorted-array
public class S01685
{
    public int[] GetSumAbsoluteDifferences(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];

        var sum = nums[0];
        
        for (var i = 1; i < n; i++)
        {
            sum += nums[i];
            result[i] = nums[i] * (i + 1) - sum;
        }

        sum = nums[n - 1];

        for (var i = n - 2; i >= 0; i--)
        {
            sum += nums[i];
            result[i] += (sum - nums[i] * (n - i));
        }

        return result;
    }
}