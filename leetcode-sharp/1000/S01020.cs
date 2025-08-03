namespace leetcode_sharp;

// 1020. Number of Enclaves
// https://leetcode.com/problems/number-of-enclaves/
public class S01020
{
    private const int Water = 0;
    private const int Land = 1;
    private readonly int[] _directions = [0, 1, 0, -1, 0];

    public int NumEnclaves(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        for (var x = 0; x < m; x++)
        {
            for (var y = 0; y < n; y++)
            {
                if (x == 0 || y == 0 || x == m - 1 || y == n - 1)
                {
                    markWater(grid, x, y);
                }
            }
        }

        return grid.Sum(row => row.Count(cell => cell == Land));
    }

    private void markWater(IReadOnlyList<int[]> grid, int x, int y)
    {
        if (x < 0 || x >= grid.Count || y < 0 || y >= grid[0].Length || grid[x][y] == Water)
        {
            return;
        }

        grid[x][y] = Water;

        for (var i = 0; i < 4; ++i)
        {
            var nextX = x + _directions[i];
            var nextY = y + _directions[i + 1];
            markWater(grid, nextX, nextY);
        }
    }
}