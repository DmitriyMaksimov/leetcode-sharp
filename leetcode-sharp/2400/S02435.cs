namespace leetcode_sharp;

// 2435. Paths in Matrix Whose Sum Is Divisible by K
// https://leetcode.com/problems/paths-in-matrix-whose-sum-is-divisible-by-k
public class S02435
{
    public int NumberOfPaths(int[][] grid, int k)
    {
        const int mod = 1_000_000_007;
        var m = grid.Length;
        var n = grid[0].Length;

        var dp = new int[m][][];

        for (var i = 0; i < m; i++)
        {
            dp[i] = new int[n][];

            for (var j = 0; j < n; j++)
            {
                dp[i][j] = new int[k];
            }
        }

        dp[0][0][grid[0][0] % k] = 1;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                for (var s = 0; s < k; s++)
                {
                    var next = (s + grid[i][j]) % k;

                    if (j > 0)
                    {
                        dp[i][j][next] = (dp[i][j][next] + dp[i][j - 1][s]) % mod;
                    }

                    if (i > 0)
                    {
                        dp[i][j][next] = (dp[i][j][next] + dp[i - 1][j][s]) % mod;
                    }
                }
            }
        }

        return dp[m - 1][n - 1][0];
    }
}