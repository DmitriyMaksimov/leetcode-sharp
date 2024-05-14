namespace leetcode_sharp;

// 1219. Path with Maximum Gold
// https://leetcode.com/problems/path-with-maximum-gold
public class S01219
{
    private readonly int[] _directions = [0, 1, 0, -1, 0];
    private int _m;
    private int _n;

    public int GetMaximumGold(int[][] grid)
    {
        _m = grid.Length;
        _n = grid[0].Length;

        var result = 0;
        
        for (var row = 0; row < _m; row++)
        {
            for (var col = 0; col < _n; col++)
            {
                result = Math.Max(result, FindMaxGold(grid, row, col));
            }
        }

        return result;
    }

    private int FindMaxGold(int[][] grid, int row, int col)
    {
        if (row < 0 || row == _m || col < 0 || col == _n || grid[row][col] == 0)
        {
            return 0;
        }

        var origin = grid[row][col];
        grid[row][col] = 0;
        var maxGold = 0;
        
        for (var i = 0; i < _directions.Length - 1; i++)
        {
            maxGold = Math.Max(maxGold, FindMaxGold(grid, row + _directions[i], col + _directions[i + 1]));
        }

        grid[row][col] = origin;

        return maxGold + origin;
    }
}