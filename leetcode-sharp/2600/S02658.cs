namespace leetcode_sharp;

// 2658. Maximum Number of Fish in a Grid
// https://leetcode.com/problems/maximum-number-of-fish-in-a-grid
public class S02658
{
    public int FindMaxFish(int[][] grid)
    {
        var result = 0;

        for (var r = 0; r < grid.Length; ++r)
        {
            for (var c = 0; c < grid[r].Length; ++c)
            {
                result = Math.Max(result, Dfs(r, c, grid));
            }
        }

        return result;
    }

    private static int Dfs(int r, int c, int[][] g)
    {
        if (Math.Min(r, c) < 0 || r == g.Length || c == g[r].Length || g[r][c] == 0)
        {
            return 0;
        }

        var temp = g[r][c];
        g[r][c] = 0;

        return temp + Dfs(r + 1, c, g) + Dfs(r, c + 1, g) + Dfs(r - 1, c, g) + Dfs(r, c - 1, g);
    }
}
