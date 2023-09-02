namespace leetcode_sharp;

// 674. Longest Continuous Increasing Subsequence
// https://leetcode.com/problems/longest-continuous-increasing-subsequence/
public class S00674
{
    public int FindLengthOfLCIS(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var max = 1;
        var cur = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                cur++;
            }
            else
            {
                max = Math.Max(max, cur);
                cur = 1;
            }
        }

        return Math.Max(max, cur);
    }
}