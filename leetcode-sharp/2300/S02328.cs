namespace leetcode_sharp;

// 2328. Number of Increasing Paths in a Grid
// https://leetcode.com/problems/number-of-increasing-paths-in-a-grid/
public class S02328
{
    private const int Mod = 1_000_000_007;

    public int CountPaths(int[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;

        var dp = new int[n, m];
        for (var row = 0; row < n; row++)
        {
            for (var col = 0; col < m; col++)
            {
                dp[row, col] = -1;
            }
        }

        var paths = 0;
        for (var row = 0; row < n; row++)
        {
            for (var col = 0; col < m; col++)
            {
                paths = (paths + solve(grid, row, col, -1, dp)) % Mod;
            }
        }

        return paths;
    }

    private static int solve(int[][] grid, int row, int col, int prevValue, int[,] dp)
    {
        if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || grid[row][col] <= prevValue)
        {
            return 0;
        }

        if (dp[row, col] != -1)
        {
            return dp[row, col];
        }

        var value = grid[row][col];
        
        var left = solve(grid, row, col - 1, value, dp);
        var right = solve(grid, row, col + 1, value, dp);
        var up = solve(grid, row - 1, col, value, dp);
        var down = solve(grid, row + 1, col, value, dp);

        return dp[row, col] = (left + right + up + down + 1) % Mod;
    }
}