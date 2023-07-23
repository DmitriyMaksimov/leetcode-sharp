namespace leetcode_sharp;

// 64. Minimum Path Sum
// https://leetcode.com/problems/minimum-path-sum/
public class S00064
{
    public int MinPathSum(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        if (m == 1 && n == 1)
        {
            return grid[0][0];
        }

        var minSumsGrid = new int[m, n];

        minSumsGrid[m - 1, n - 1] = grid[m - 1][n - 1];

        // Bottom edge
        for (var i = n - 1; i > 0; i--)
        {
            minSumsGrid[m - 1, i - 1] = minSumsGrid[m - 1, i] + grid[m - 1][i - 1];
        }

        // Right edge
        for (var i = m - 1; i > 0; i--)
        {
            minSumsGrid[i - 1, n - 1] = minSumsGrid[i, n - 1] + grid[i - 1][n - 1];
        }

        for (var x = m - 1 - 1; x >= 0; x--)
        {
            for (var y = n - 1 - 1; y >= 0; y--)
            {
                minSumsGrid[x, y] = grid[x][y] + Math.Min(minSumsGrid[x + 1, y], minSumsGrid[x, y + 1]);
            }
        }

        return minSumsGrid[0, 0];
    }
}