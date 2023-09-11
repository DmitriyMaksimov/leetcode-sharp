namespace leetcode_sharp;

// 1800. Maximum Ascending Subarray Sum
// https://leetcode.com/problems/maximum-ascending-subarray-sum/
public class S01800
{
    public int MaxAscendingSum(int[] nums)
    {
        var max = nums[0];
        var sum = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                sum += nums[i];
            }
            else
            {
                sum = nums[i];
            }

            max = Math.Max(max, sum);
        }

        return max;
    }
}