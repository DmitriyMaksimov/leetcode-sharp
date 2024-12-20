namespace leetcode_sharp;

// 1895. Largest Magic Square
// https://leetcode.com/problems/largest-magic-square
public class S01895
{
    public int LargestMagicSquare(int[][] grid)
    {
        var totalRows = grid.Length;
        var totalColumns = grid[0].Length;
        var rows = new int[totalRows, totalColumns + 1];
        var cols = new int[totalRows + 1, totalColumns];

        for (var i = 0; i < totalRows; i++)
        {
            for (var j = 0; j < totalColumns; j++)
            {
                rows[i, j + 1] = rows[i, j] + grid[i][j];
                cols[i + 1, j] = cols[i, j] + grid[i][j];
            }
        }

        for (var side = Math.Min(totalRows, totalColumns); side > 1; side--)
        {
            for (var i = 0; i <= totalRows - side; i++)
            {
                for (var j = 0; j <= totalColumns - side; j++)
                {
                    if (IsMagic(grid, rows, cols, i, j, side))
                    {
                        return side;
                    }
                }
            }
        }

        return 1;
    }

    private static bool IsMagic(int[][] grid, int[,] rows, int[,] cols, int r, int c, int side)
    {
        var sum = rows[r, c + side] - rows[r, c];
        var d1 = 0;
        var d2 = 0;

        for (var k = 0; k < side; k++)
        {
            d1 += grid[r + k][c + k];
            d2 += grid[r + side - 1 - k][c + k];

            if (rows[r + k, c + side] - rows[r + k, c] != sum || cols[r + side, c + k] - cols[r, c + k] != sum)
            {
                return false;
            }
        }

        return d1 == sum && d2 == sum;
    }
}
