namespace leetcode_sharp;

// 3882. Minimum XOR Path in a Grid
// https://leetcode.com/problems/minimum-xor-path-in-a-grid
public class S03882
{
    private int _n;
    private int _m;
    private int[][][] _dp = null!;

    public int MinCost(int[][] grid)
    {
        _n = grid.Length;
        _m = grid[0].Length;
        _dp = new int[_n][][];

        for (var i = 0; i < _n; i++)
        {
            _dp[i] = new int[_m][];

            for (var j = 0; j < _m; j++)
            {
                _dp[i][j] = [.. Enumerable.Repeat(-1, 1024)];
            }
        }

        return Dfs(0, 0, 0, grid);
    }

    private int Dfs(int i, int j, int temp, int[][] grid)
    {
        if (i >= _n || j >= _m)
        {
            return int.MaxValue;
        }

        temp ^= grid[i][j];

        if (i == _n - 1 && j == _m - 1)
        {
            return temp;
        }

        if (_dp[i][j][temp] != -1)
        {
            return _dp[i][j][temp];
        }

        var right = Dfs(i + 1, j, temp, grid);
        var down = Dfs(i, j + 1, temp, grid);

        return _dp[i][j][temp] = Math.Min(right, down);
    }
}