namespace leetcode_sharp;

// 3197. Find the Minimum Area to Cover All Ones II
// https://leetcode.com/problems/find-the-minimum-area-to-cover-all-ones-ii
public class S03197
{
    public int MinimumSum(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var result = int.MaxValue;

        for (var i = 0; i < m; i++)
        {
            var one = MinimumArea(grid, 0, i, 0, n - 1);

            for (var j = 0; j < n; j++)
            {
                var two = MinimumArea(grid, i + 1, m - 1, 0, j);
                var three = MinimumArea(grid, i + 1, m - 1, j + 1, n - 1);
                result = Math.Min(result, one + two + three);
            }
        }

        for (var j = 0; j < n; j++)
        {
            var one = MinimumArea(grid, 0, m - 1, 0, j);

            for (var i = 0; i < m; i++)
            {
                var two = MinimumArea(grid, 0, i, j + 1, n - 1);
                var three = MinimumArea(grid, i + 1, m - 1, j + 1, n - 1);
                result = Math.Min(result, one + two + three);
            }
        }

        for (var j = n - 1; j >= 0; j--)
        {
            var one = MinimumArea(grid, 0, m - 1, j + 1, n - 1);

            for (var i = 0; i < m; i++)
            {
                var two = MinimumArea(grid, 0, i, 0, j);
                var three = MinimumArea(grid, i + 1, m - 1, 0, j);
                result = Math.Min(result, one + two + three);
            }
        }

        for (var i = m - 1; i >= 0; i--)
        {
            var one = MinimumArea(grid, i + 1, m - 1, 0, n - 1);

            for (var j = 0; j < n; j++)
            {
                var two = MinimumArea(grid, 0, i, 0, j);
                var three = MinimumArea(grid, 0, i, j + 1, n - 1);
                result = Math.Min(result, one + two + three);
            }
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = i + 1; j < m; j++)
            {
                var one = MinimumArea(grid, 0, i, 0, n - 1);
                var two = MinimumArea(grid, i + 1, j, 0, n - 1);
                var three = MinimumArea(grid, j + 1, m - 1, 0, n - 1);

                result = Math.Min(result, one + two + three);
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                var one = MinimumArea(grid, 0, m - 1, 0, i);
                var two = MinimumArea(grid, 0, m - 1, i + 1, j);
                var three = MinimumArea(grid, 0, m - 1, j + 1, n - 1);

                result = Math.Min(result, one + two + three);
            }
        }

        return result;
    }

    private static int MinimumArea(int[][] grid, int startRow, int endRow, int startCol, int endCol)
    {
        var minRow = int.MaxValue;
        var maxRow = -1;
        var minCol = int.MaxValue;
        var maxCol = -1;
        var found = false;

        for (var i = startRow; i <= endRow; i++)
        {
            for (var j = startCol; j <= endCol; j++)
            {
                if (grid[i][j] == 1)
                {
                    minRow = Math.Min(minRow, i);
                    maxRow = Math.Max(maxRow, i);
                    minCol = Math.Min(minCol, j);
                    maxCol = Math.Max(maxCol, j);
                    found = true;
                }
            }
        }

        return found ? (maxRow - minRow + 1) * (maxCol - minCol + 1) : 0;
    }
}