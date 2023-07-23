namespace leetcode_sharp;

// 695. Max Area of Island
// https://leetcode.com/problems/max-area-of-island/
public class S00695
{
    private readonly HashSet<(int, int)> _visited = new();
    private readonly int[] _directions = {0, -1, 0, 1, 0};

    public int MaxAreaOfIsland(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var maxArea = 0;

        for (var col = 0; col < m; ++col)
        {
            for (var row = 0; row < n; ++row)
            {
                maxArea = Math.Max(maxArea, calcArea(grid, col, row, m, n));
            }
        }

        return maxArea;
    }

    private int calcArea(int[][] grid, int col, int row, int m, int n)
    {
        if (_visited.Contains((col, row)) || col < 0 || col >= m || row < 0 || row >= n || grid[col][row] != 1)
        {
            return 0;
        }

        _visited.Add((col, row));

        var area = 1;
        
        for (var d = 0; d < 4; ++d)
        {
            area += calcArea(grid, col + _directions[d], row + _directions[d + 1], m, n);
        }

        return area;
    }
}