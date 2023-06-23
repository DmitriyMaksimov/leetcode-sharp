namespace leetcode_sharp;

// 1027. Longest Arithmetic Subsequence
// https://leetcode.com/problems/longest-arithmetic-subsequence/
public class S01027
{
    public int LongestArithSeqLength(int[] nums)
    {
        var n = nums.Length;
        if (n <= 2)
        {
            return n;
        }

        var longest = 2;
        var dp = new Dictionary<int, int>[n];

        for (var i = 0; i < n; i++)
        {
            dp[i] = new Dictionary<int, int>();
            for (var j = 0; j < i; j++)
            {
                var diff = nums[i] - nums[j];
                dp[i][diff] = dp[j].GetValueOrDefault(diff, 1) + 1;
                longest = Math.Max(longest, dp[i][diff]);
            }
        }

        return longest;
    }
}