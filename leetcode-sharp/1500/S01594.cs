namespace leetcode_sharp;

// 1594. Maximum Non Negative Product in a Matrix
// https://leetcode.com/problems/maximum-non-negative-product-in-a-matrix
public class S01594
{
    private const int Mod = 1_000_000_007;

    public int MaxProductPath(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var dp = new (long min, long max)[m, n];

        dp[0, 0] = (grid[0][0], grid[0][0]);

        for (var i = 1; i < m; i++)
        {
            long val = grid[i][0];
            var prev = dp[i - 1, 0];
            dp[i, 0] = (prev.min * val, prev.max * val);
        }

        for (var j = 1; j < n; j++)
        {
            long val = grid[0][j];
            var prev = dp[0, j - 1];
            dp[0, j] = (prev.min * val, prev.max * val);
        }

        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                long val = grid[i][j];

                var top = dp[i - 1, j];
                var left = dp[i, j - 1];

                long[] candidates =
                {
                    top.min * val,
                    top.max * val,
                    left.min * val,
                    left.max * val
                };

                var min = candidates.Min();
                var max = candidates.Max();

                dp[i, j] = (min, max);
            }
        }

        var result = dp[m - 1, n - 1].max;

        return result < 0 ? -1 : (int)(result % Mod);
    }
}