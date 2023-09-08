namespace leetcode_sharp;

// 1260. Shift 2D Grid
// https://leetcode.com/problems/shift-2d-grid/
public class S01260
{
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        IList<IList<int>> result = new List<IList<int>>();
        for (var i = 0; i < m; i++)
        {
            result.Add(new int[n]);
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var index = (i * n + j + k) % (m * n);
                var row = index / n;
                var col = index % n;
                result[row][col] = grid[i][j];
            }
        }

        return result;
    }
}