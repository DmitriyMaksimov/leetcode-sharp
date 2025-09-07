namespace leetcode_sharp;

// 3665. Twisted Mirror Path Count
// https://leetcode.com/problems/twisted-mirror-path-count
public class S03665
{
    private const int Mod = 1_000_000_007;
    private int[,,] _dp = null!;
    private int _rows;
    private int _cols;

    public int UniquePaths(int[][] grid)
    {
        _rows = grid.Length;
        _cols = grid[0].Length;

        _dp = new int[_rows, _cols, 2];
        for (var i = 0; i < _rows; i++)
        {
            for (var j = 0; j < _cols; j++)
            {
                for (var d = 0; d < 2; d++)
                {
                    _dp[i, j, d] = -1;
                }
            }
        }

        return Dfs(grid, 0, 0, 0);
    }


    private int Dfs(int[][] grid, int i, int j, int dir)
    {
        if (i >= _rows || j >= _cols)
        {
            return 0;
        }

        if (i == _rows - 1 && j == _cols - 1)
        {
            return 1;
        }

        if (_dp[i, j, dir] != -1)
        {
            return _dp[i, j, dir];
        }

        if (grid[i][j] == 1)
        {
            return dir == 1 ? Dfs(grid, i + 1, j, 0) : Dfs(grid, i, j + 1, 1);
        }

        long moves = 0;

        if (j + 1 < _cols)
        {
            moves += Dfs(grid, i, j + 1, 1);
        }

        if (i + 1 < _rows)
        {
            moves += Dfs(grid, i + 1, j, 0);
        }

        return _dp[i, j, dir] = (int)(moves % Mod);
    }
}