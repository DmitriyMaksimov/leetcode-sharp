namespace leetcode_sharp;

// 3693. Climbing Stairs II
// https://leetcode.com/problems/climbing-stairs-ii
public class S03693
{
    public int ClimbStairs(int n, int[] costs)
    {
        costs = [0, .. costs];
        var dp = Enumerable.Repeat(int.MaxValue / 2, n + 3).ToArray();

        dp[n] = costs[n];

        for (var i = n - 1; i >= 0; i--)
        {
            dp[i] = costs[i] + Math.Min(dp[i + 1] + 1, Math.Min(dp[i + 2] + 4, dp[i + 3] + 9));
        }

        return dp[0];
    }
}