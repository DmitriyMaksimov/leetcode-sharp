namespace leetcode_sharp;

// 3742. Maximum Path Score in a Grid
// https://leetcode.com/problems/maximum-path-score-in-a-grid
public class S03742
{
    public int MaxPathScore(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var dp = new int[m][][];
        for (var i = 0; i < m; i++)
        {
            dp[i] = new int[n][];

            for (var j = 0; j < n; j++)
            {
                dp[i][j] = new int[k + 1];
            
                for (var cst = 0; cst <= k; cst++)
                {
                    dp[i][j][cst] = -1;
                }
            }
        }

        int[] score = [0, 1, 2];
        int[] cost = [0, 1, 1];

        dp[0][0][0] = 0;

        for (var r = 0; r < m; r++)
        {
            for (var c = 0; c < n; c++)
            {
                for (var cst = 0; cst <= k; cst++)
                {
                    if (dp[r][c][cst] == -1)
                    {
                        continue;
                    }

                    var currentScore = dp[r][c][cst];

                    if (r + 1 < m)
                    {
                        var val = grid[r + 1][c];
                        var newCost = cst + cost[val];
                        var newScore = currentScore + score[val];

                        if (newCost <= k)
                        {
                            dp[r + 1][c][newCost] = Math.Max(dp[r + 1][c][newCost], newScore);
                        }
                    }

                    if (c + 1 < n)
                    {
                        var val = grid[r][c + 1];
                        var newCost = cst + cost[val];
                        var newScore = currentScore + score[val];

                        if (newCost <= k)
                        {
                            dp[r][c + 1][newCost] = Math.Max(dp[r][c + 1][newCost], newScore);
                        }
                    }
                }
            }
        }

        var result = -1;
        for (var i = 0; i <= k; i++)
        {
            result = Math.Max(result, dp[m - 1][n - 1][i]);
        }

        return result;
    }
}