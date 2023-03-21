namespace leetcode_sharp;

// 200. Number of Islands
// https://leetcode.com/problems/number-of-islands/
public class S00200
{
    private readonly int[] _directions = {0, -1, 0, 1, 0};

    public int NumIslands(char[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var count = 0;

        for (var col = 0; col < m; ++col)
        {
            for (var row = 0; row < n; ++row)
            {
                if (grid[col][row] == '1')
                {
                    ++count;
                    visitIsland(grid, col, row, m, n);
                }
            }
        }

        return count;
    }

    private void visitIsland(char[][] grid, int col, int row, int m, int n)
    {
        if (col < 0 || col >= m || row < 0 || row >= n || grid[col][row] == '0')
        {
            return;
        }

        grid[col][row] = '0';

        for (var d = 0; d < 4; ++d)
        {
            visitIsland(grid, col + _directions[d], row + _directions[d + 1], m, n);
        }
    }
}