namespace leetcode_sharp;

// 375. Guess Number Higher or Lower II
// https://leetcode.com/problems/guess-number-higher-or-lower-ii
public class S00375
{
    public int GetMoneyAmount(int n)
    {
        var dp = new int[n + 2, n + 2];

        for (var l = 1; l < n; l++)
        {
            for (var i = 1; i <= n - l; i++)
            {
                var j = i + l;
                dp[i, j] = int.MaxValue;

                for (var k = i; k <= j; k++)
                {
                    dp[i, j] = Math.Min(dp[i, j], k + Math.Max(dp[i, k - 1], dp[k + 1, j]));
                }
            }
        }

        return dp[1, n];
    }
}
