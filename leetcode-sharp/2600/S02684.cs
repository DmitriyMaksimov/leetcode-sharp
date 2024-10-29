namespace leetcode_sharp;

// 2684. Maximum Number of Moves in a Grid
// https://leetcode.com/problems/maximum-number-of-moves-in-a-grid
public class S02684
{
    private readonly int[][] _directions = [[0, 1], [1, 1], [-1, 1]];
    private int _m;
    private int _n;
    private int[][] _cache = null!;

    public int MaxMoves(int[][] grid)
    {
        _m = grid.Length;
        _n = grid[0].Length;
        _cache = new int[_m][];

        for (var i = 0; i < _m; i++)
        {
            _cache[i] = Enumerable.Repeat(-1, _n).ToArray();
        }

        var result = 0;
        for (var i = 0; i < _m; i++)
        {
            result = Math.Max(result, Dp(grid, i, 0));
        }

        return result;
    }

    private int Dp(int[][] grid, int i, int j)
    {
        if (_cache[i][j] != -1)
        {
            return _cache[i][j];
        }

        var result = 0;

        foreach (var dir in _directions)
        {
            var nextI = i + dir[0];
            var nextJ = j + dir[1];

            if (nextI >= 0 && nextI < _m && nextJ < _n && grid[i][j] < grid[nextI][nextJ])
            {
                result = Math.Max(result, 1 + Dp(grid, nextI, nextJ));
            }
        }

        return _cache[i][j] = result;
    }
}
