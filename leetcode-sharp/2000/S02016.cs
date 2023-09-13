namespace leetcode_sharp;

// 2016. Maximum Difference Between Increasing Elements
// https://leetcode.com/problems/maximum-difference-between-increasing-elements/
public class S02016
{
    public int MaximumDifference(int[] nums)
    {
        var max = -1;
        var min = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > min)
            {
                max = Math.Max(max, nums[i] - min);
            }
            else
            {
                min = nums[i];
            }
        }

        return max;
    }
}