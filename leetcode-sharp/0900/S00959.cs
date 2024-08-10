namespace leetcode_sharp;

// 959. Regions Cut By Slashes
// https://leetcode.com/problems/regions-cut-by-slashes
public class S00959
{
    public int RegionsBySlashes(string[] grid)
    {
        var n = grid.Length;
        var regions = 0;

        var g = new int[n * 3][];

        for (var i = 0; i < g.Length; ++i)
        {
            g[i] = new int[n * 3];
        }

        for (var i = 0; i < n; ++i)
        {
            for (var j = 0; j < n; ++j)
            {
                switch (grid[i][j])
                {
                    case '/':
                        g[i * 3][j * 3 + 2] = g[i * 3 + 1][j * 3 + 1] = g[i * 3 + 2][j * 3] = 1;
                        break;
                    case '\\':
                        g[i * 3][j * 3] = g[i * 3 + 1][j * 3 + 1] = g[i * 3 + 2][j * 3 + 2] = 1;
                        break;
                }
            }
        }

        for (var i = 0; i < n * 3; ++i)
        {
            for (var j = 0; j < n * 3; ++j)
            {
                regions += Dfs(g, i, j) > 0 ? 1 : 0;
            }
        }

        return regions;
    }

    private int Dfs(int[][] g, int i, int j)
    {
        if (Math.Min(i, j) < 0 || Math.Max(i, j) >= g.Length || g[i][j] != 0)
        {
            return 0;
        }

        g[i][j] = 1;

        return 1 + Dfs(g, i - 1, j) + Dfs(g, i + 1, j) + Dfs(g, i, j - 1) + Dfs(g, i, j + 1);
    }
}
