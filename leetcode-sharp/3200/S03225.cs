namespace leetcode_sharp;

// 3225. Maximum Score From Grid Operations
// https://leetcode.com/problems/maximum-score-from-grid-operations
public class S03225
{
    public long MaximumScore(int[][] grid)
    {
        var n = grid.Length;
        if (n == 1)
        {
            return 0;
        }

        var colSum = new long[100, 101];
        var dp = new long[100, 101, 2];

        for (var j = 0; j < n; j++)
        {
            colSum[j, 0] = 0;
            for (var i = 0; i < n; i++)
            {
                colSum[j, i + 1] = colSum[j, i] + grid[i][j];
            }
        }

        for (var j = 0; j < n; j++)
        {
            for (var b = 0; b <= n; b++)
            {
                dp[j, b, 0] = 0;
                dp[j, b, 1] = 0;
            }
        }

        for (var j = 1; j < n; j++)
        {
            for (var b0 = 0; b0 <= n; b0++)
            {
                var p0 = dp[j - 1, b0, 0];
                var p1 = dp[j - 1, b0, 1];

                for (var b1 = 0; b1 <= n; b1++)
                {
                    var isBigger = b1 > b0;

                    var prvX = isBigger ? (colSum[j - 1, b1] - colSum[j - 1, b0]) : 0;
                    var curX = !isBigger ? (colSum[j, b0] - colSum[j, b1]) : 0;

                    dp[j, b1, 0] = Math.Max(dp[j, b1, 0], Math.Max(prvX + p0, p1));
                    dp[j, b1, 1] = Math.Max(dp[j, b1, 1], curX + Math.Max(p1, prvX + p0));
                }
            }
        }

        var result = 0L;
        for (var b = 0; b <= n; b++)
        {
            result = Math.Max(result, dp[n - 1, b, 1]);
        }

        return result;
    }
}