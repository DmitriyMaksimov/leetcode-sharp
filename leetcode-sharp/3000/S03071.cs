namespace leetcode_sharp;

// 3071. Minimum Operations to Write the Letter Y on a Grid
// https://leetcode.com/problems/minimum-operations-to-write-the-letter-y-on-a-grid
public class S03071
{
    public int MinimumOperationsToWriteY(int[][] grid)
    {
        var result = int.MaxValue;

        for (var i = 0; i < 3; ++i)
        {
            for (var j = 0; j < 3; ++j)
            {
                if (i != j)
                {
                    result = Math.Min(result, GetOperationCount(grid, i, j));
                }
            }
        }

        return result;
    }

    private static int GetOperationCount(int[][] grid, int y, int notY)
    {
        var count = 0;
        var n = grid.Length;

        for (var i = 0; i < n; ++i)
        {
            for (var j = 0; j < n; ++j)
            {
                if ((i <= n / 2 && (i == j || i + j == n - 1)) || (i > n / 2 && j == n / 2))
                {
                    if (y != grid[i][j])
                    {
                        count++;
                    }
                }
                else
                {
                    if (notY != grid[i][j])
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}
