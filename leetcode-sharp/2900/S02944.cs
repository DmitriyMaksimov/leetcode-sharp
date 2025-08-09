namespace leetcode_sharp;

// 2944. Minimum Number of Coins for Fruits
// https://leetcode.com/problems/minimum-number-of-coins-for-fruits
public class S02944
{
    public int MinimumCoins(int[] prices)
    {
        var n = prices.Length;

        var dp = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
        dp[n] = 0;

        for (var i = n - 1; i >= 0; i--)
        {
            var maxJump = Math.Min(2 * i + 2, n);

            for (var j = i + 1; j <= maxJump; j++)
            {
                dp[i] = Math.Min(dp[i], dp[j]);
            }

            dp[i] += prices[i];
        }

        return dp[0];
    }
}