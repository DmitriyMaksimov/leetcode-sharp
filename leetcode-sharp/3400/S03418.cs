namespace leetcode_sharp;

// 3418. Maximum Amount of Money Robot Can Earn
// https://leetcode.com/problems/maximum-amount-of-money-robot-can-earn
public class S03418
{
    public int MaximumAmount(int[][] coins)
    {
        var n = coins.Length;
        var m = coins[0].Length;

        var dp = new int[n][][];
        for (var i = 0; i < n; i++)
        {
            dp[i] = new int[m][];
            for (var j = 0; j < m; j++)
            {
                dp[i][j] = new int[3];
                Array.Fill(dp[i][j], (int)-1e9);
            }
        }

        dp[0][0][0] = coins[0][0];
        dp[0][0][1] = 0;
        dp[0][0][2] = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                for (var k = 0; k < 3; k++)
                {
                    if (i > 0)
                    {
                        dp[i][j][k] = Math.Max(dp[i][j][k], dp[i - 1][j][k] + coins[i][j]);

                        if (k > 0)
                        {
                            dp[i][j][k] = Math.Max(dp[i][j][k], dp[i - 1][j][k - 1]);
                        }
                    }

                    if (j > 0)
                    {
                        dp[i][j][k] = Math.Max(dp[i][j][k], dp[i][j - 1][k] + coins[i][j]);

                        if (k > 0)
                        {
                            dp[i][j][k] = Math.Max(dp[i][j][k], dp[i][j - 1][k - 1]);
                        }
                    }
                }
            }
        }

        return Math.Max(
            dp[n - 1][m - 1][0],
            Math.Max(dp[n - 1][m - 1][1], dp[n - 1][m - 1][2])
        );
    }
}