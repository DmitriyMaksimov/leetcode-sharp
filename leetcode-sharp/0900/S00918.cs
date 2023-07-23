namespace leetcode_sharp;

// 918. Maximum Sum Circular Subarray
// https://leetcode.com/problems/maximum-sum-circular-subarray/
public class S00918
{
    public int MaxSubarraySumCircular(int[] nums)
    {
        var max = nums[0];
        var currentMax = 0;
        var min = nums[0];
        var currentMin = 0;
        var total = 0;
        
        foreach (var n in nums)
        {
            currentMax = Math.Max(currentMax, 0) + n;
            max = Math.Max(max, currentMax);

            currentMin = Math.Min(currentMin, 0) + n;
            min = Math.Min(min, currentMin);

            total += n;
        }
        
        return total == min ? max : Math.Max(max, total - min);
    }
}