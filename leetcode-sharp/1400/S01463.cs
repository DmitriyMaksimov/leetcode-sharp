namespace leetcode_sharp;

// 1463. Cherry Pickup II
// https://leetcode.com/problems/cherry-pickup-ii
public class S01463
{
    private readonly Dictionary<(int row, int col1, int col2), int> _dp = new();
    private int _m;
    private int _n;
    private int[][] _grid = null!;

    public int CherryPickup(int[][] grid)
    {
        _grid = grid;
        _m = grid.Length;
        _n = grid[0].Length;

        return dfs(0, 0, _n - 1);
    }

    private int dfs(int row, int col1, int col2)
    {
        if (row == _m)
        {
            return 0;
        }

        if (_dp.TryGetValue((row, col1, col2), out var dpValue))
        {
            return dpValue;
        }

        var result = 0;

        for (var i = -1; i <= 1; i++)
        {
            for (var j = -1; j <= 1; j++)
            {
                var newCol1 = col1 + i;
                var newCol2 = col2 + j;

                if (newCol1 >= 0 && newCol1 < _n && newCol2 >= 0 && newCol2 < _n)
                {
                    result = Math.Max(result, dfs(row + 1, newCol1, newCol2));
                }
            }
        }

        var cherries = col1 == col2 ? _grid[row][col1] : _grid[row][col1] + _grid[row][col2];

        return _dp[(row, col1, col2)] = result + cherries;
    }
}