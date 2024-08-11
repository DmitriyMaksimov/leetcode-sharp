namespace leetcode_sharp;

// 1568. Minimum Number of Days to Disconnect Island
// https://leetcode.com/problems/minimum-number-of-days-to-disconnect-island
public class S01568
{
    public int MinDays(int[][] grid)
    {
        if (NoOfIsland(grid) != 1)
        {
            return 0;
        }

        foreach (var t in grid)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (t[j] == 1)
                {
                    t[j] = 0;
                    if (NoOfIsland(grid) != 1)
                    {
                        return 1;
                    }

                    t[j] = 1;
                }
            }
        }

        return 2;
    }

    private static int NoOfIsland(int[][] grid)
    {
        var result = 0;
        var visited = new bool[grid.Length][];

        for (var i = 0; i < grid.Length; i++)
        {
            visited[i] = new bool[grid[0].Length];
        }

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (!visited[i][j] && grid[i][j] == 1)
                {
                    result++;
                    Dfs(visited, grid, i, j);
                }
            }
        }

        return result;
    }

    private static void Dfs(bool[][] visited, int[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i == grid.Length || j == grid[0].Length || visited[i][j] || grid[i][j] == 0)
        {
            return;
        }

        visited[i][j] = true;
        Dfs(visited, grid, i - 1, j);
        Dfs(visited, grid, i + 1, j);
        Dfs(visited, grid, i, j - 1);
        Dfs(visited, grid, i, j + 1);
    }
}
