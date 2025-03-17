namespace leetcode_sharp;

// 1559. Detect Cycles in 2D Grid
// https://leetcode.com/problems/detect-cycles-in-2d-grid
public class S01559
{
    private readonly int[] _directions = [0, 1, 0, -1, 0];

    public bool ContainsCycle(char[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;
        var visited = new bool[n][];

        for (var i = 0; i < n; i++)
        {
            visited[i] = new bool[m];
        }

        for (var i = 0; i < n; ++i)
        {
            for (var j = 0; j < m; ++j)
            {
                if (!visited[i][j] && IsCyclic(grid, visited, i, j, -1, -1))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool IsCyclic(char[][] grid, bool[][] visited, int i, int j, int x, int y)
    {
        visited[i][j] = true;

        for (var direction = 0; direction < _directions.Length - 1; ++direction)
        {
            var a = i + _directions[direction];
            var b = j + _directions[direction + 1];

            if (a >= 0 && a < grid.Length && b >= 0 && b < grid[0].Length && grid[a][b] == grid[i][j] && !(x == a && y == b))
            {
                if (visited[a][b] || IsCyclic(grid, visited, a, b, i, j))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
