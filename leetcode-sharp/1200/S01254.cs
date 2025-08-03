namespace leetcode_sharp;

// 1254. Number of Closed Islands
// https://leetcode.com/problems/number-of-closed-islands/
public class S01254
{
    private const int Land = 0;
    private const int Water = 1;
    private readonly int[] _directions = [0, 1, 0, -1, 0];

    public int ClosedIsland(int[][] grid)
    {
        var count = 0;
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == Land && isClosed(grid, i, j))
                {
                    count++;
                }
            }
        }

        return count;
    }

    private bool isClosed(IReadOnlyList<int[]> grid, int x, int y)
    {
        if (x < 0 || x >= grid.Count || y < 0 || y >= grid[0].Length)
        {
            return false;
        }

        if (grid[x][y] == Water)
        {
            return true;
        }

        grid[x][y] = Water;

        var result = true;

        for (var i = 0; i < 4; ++i)
        {
            var nextX = x + _directions[i];
            var nextY = y + _directions[i + 1];
            result &= isClosed(grid, nextX, nextY);
        }

        return result;
    }
}