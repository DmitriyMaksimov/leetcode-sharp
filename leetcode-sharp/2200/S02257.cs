namespace leetcode_sharp;

// 2257. Count Unguarded Cells in the Grid
// https://leetcode.com/problems/count-unguarded-cells-in-the-grid
public class S02257
{
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        int[][] directions = [[1, 0], [-1, 0], [0, 1], [0, -1]];
        var grid = new char[m][];
        for (var i = 0; i < m; i++)
        {
            grid[i] = new char[n];
        }

        var result = m * n - guards.Length - walls.Length;

        foreach (var wall in walls)
        {
            grid[wall[0]][wall[1]] = 'W';
        }

        foreach (var guard in guards)
        {
            grid[guard[0]][guard[1]] = 'G';
        }

        foreach (var guard in guards)
        {
            foreach (var dir in directions)
            {
                var x = guard[0] + dir[0];
                var y = guard[1] + dir[1];
                while (x >= 0 && y >= 0 && x < m && y < n && grid[x][y] != 'G' && grid[x][y] != 'W')
                {
                    if (grid[x][y] != 'P')
                    {
                        result--;
                    }

                    grid[x][y] = 'P';
                    x += dir[0];
                    y += dir[1];
                }
            }
        }

        return result;
    }
}
