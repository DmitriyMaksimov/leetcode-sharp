namespace leetcode_sharp;

// 2304. Minimum Path Cost in a Grid
// https://leetcode.com/problems/minimum-path-cost-in-a-grid
public class S02304
{
    public int MinPathCost(int[][] grid, int[][] moveCost)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var dp = new int[m][];
        for (var i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            Array.Fill(dp[i], int.MaxValue);
        }

        dp[0] = grid[0];

        for (var i = 1; i < m; ++i)
        {
            for (var j = 0; j < n; ++j)
            {
                for (var k = 0; k < n; ++k)
                {
                    dp[i][k] = Math.Min(dp[i][k], grid[i][k] + dp[i - 1][j] + moveCost[grid[i - 1][j]][k]);
                }
            }
        }

        return dp[m - 1].Min();
    }
}
