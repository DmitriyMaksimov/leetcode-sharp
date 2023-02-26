namespace leetcode_sharp;

// 53. Maximum Subarray
// https://leetcode.com/problems/maximum-subarray/
public class S00053
{
    public int MaxSubArray(int[] nums)
    {
        var maxSum = int.MinValue;
        var currentSum = 0;
        
        foreach (var num in nums)
        {
            currentSum = Math.Max(num, currentSum + num);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}