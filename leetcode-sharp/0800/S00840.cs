namespace leetcode_sharp;

// 840. Magic Squares In Grid
// https://leetcode.com/problems/magic-squares-in-grid
public class S00840
{
    public int NumMagicSquaresInside(int[][] grid)
    {
        var result = 0;

        for (var i = 0; i <= grid.Length - 3; i++)
        {
            for (var j = 0; j <= grid[0].Length - 3; j++)
            {
                if (Helper(i, j, grid))
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static bool Helper(int x, int y, int[][] grid)
    {
        if (grid[x + 1][y + 1] != 5) return false;

        var valid = new int[16];

        for (var i = x; i <= x + 2; i++)
        {
            for (var j = y; j <= y + 2; j++)
            {
                valid[grid[i][j]]++;
            }
        }

        for (var v = 1; v <= 9; v++)
        {
            if (valid[v] != 1)
                return false;
        }

        if (grid[x][y] + grid[x][y + 1] + grid[x][y + 2] != 15) return false;
        if (grid[x][y] + grid[x + 1][y + 1] + grid[x + 2][y + 2] != 15) return false;
        if (grid[x][y] + grid[x + 1][y] + grid[x + 2][y] != 15) return false;
        if (grid[x + 2][y] + grid[x + 2][y + 1] + grid[x + 2][y + 2] != 15) return false;
        if (grid[x][y + 2] + grid[x + 1][y + 2] + grid[x + 2][y + 2] != 15) return false;
        if (grid[x][y + 2] + grid[x + 1][y + 1] + grid[x + 2][y] != 15) return false;

        return true;
    }
}
