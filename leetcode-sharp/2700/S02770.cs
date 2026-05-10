namespace leetcode_sharp;

// 2770. Maximum Number of Jumps to Reach the Last Index
// https://leetcode.com/problems/maximum-number-of-jumps-to-reach-the-last-index
public class S02770
{
    public int MaximumJumps(int[] nums, int target)
    {
        var dp = Enumerable.Repeat(-1, nums.Length).ToArray();
        dp[0] = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = i - 1; j >= 0; j--)
            {
                var diff = nums[i] - nums[j];

                if (-target <= diff && diff <= target)
                {
                    if (dp[j] > -1)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }
        }

        return dp[nums.Length - 1];
    }
}