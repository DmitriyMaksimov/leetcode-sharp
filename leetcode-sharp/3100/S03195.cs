namespace leetcode_sharp;

// 3195. Find the Minimum Area to Cover All Ones I
// https://leetcode.com/problems/find-the-minimum-area-to-cover-all-ones-i
public class S03195
{
    public int MinimumArea(int[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;
        var minRow = int.MaxValue;
        var maxRow = int.MinValue;
        var minCol = int.MaxValue;
        var maxCol = int.MinValue;

        for (var row = 0; row < n; row++)
        {
            for (var col = 0; col < m; col++)
            {
                if (grid[row][col] == 1)
                {
                    minCol = Math.Min(minCol, col);
                    minRow = Math.Min(minRow, row);
                    maxCol = Math.Max(maxCol, col);
                    maxRow = Math.Max(maxRow, row);
                }
            }
        }

        return (maxRow - minRow + 1) * (maxCol - minCol + 1);
    }
}
