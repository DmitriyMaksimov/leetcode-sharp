namespace leetcode_sharp;

// 746. Min Cost Climbing Stairs
// https://leetcode.com/problems/min-cost-climbing-stairs/
public class S00746
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var n = cost.Length;
        var dp = new int[n + 1];
        
        dp[n] = 0;
        dp[n - 1] = cost[n - 1];

        for (var i = n - 2; i >= 0; i--)
        {
            dp[i] = cost[i] + Math.Min(dp[i + 1], dp[i + 2]);
        }
        
        return Math.Min(dp[0], dp[1]);
    }
}