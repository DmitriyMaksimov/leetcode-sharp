namespace leetcode_sharp;

// 3559. Number of Ways to Assign Edge Weights II
// https://leetcode.com/problems/number-of-ways-to-assign-edge-weights-ii 
public class S03559
{
    private const int Mod = 1_000_000_007;

    public int[] AssignEdgeWeights(int[][] edges, int[][] queries)
    {
        var n = edges.Length + 1;
        var m = queries.Length;

        var graph = new List<int>[n];
        for (var i = 0; i < n; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (var edge in edges)
        {
            var u = edge[0] - 1;
            var v = edge[1] - 1;

            graph[u].Add(v);
            graph[v].Add(u);
        }

        var maxN = (int)Math.Log2(n);

        var levels = new int[n];
        var lca = new int[n, maxN + 1];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j <= maxN; j++)
            {
                lca[i, j] = -1;
            }
        }

        Dfs(0, -1, 0, levels, graph, lca);
        Init(n, maxN, lca);

        var ans = new int[m];

        for (var i = 0; i < m; i++)
        {
            var u = queries[i][0] - 1;
            var v = queries[i][1] - 1;

            var dist = GetDistance(u, v, maxN, levels, lca);

            if (dist == 0)
            {
                ans[i] = 0;
                continue;
            }

            ans[i] = (int)PowerMod(2, dist - 1, Mod);
        }

        return ans;
    }

    private static void Dfs(int u, int parent, int level, int[] levels, List<int>[] graph, int[,] lca)
    {
        levels[u] = level;
        lca[u, 0] = parent;

        foreach (var v in graph[u].Where(v => v != parent))
        {
            Dfs(v, u, level + 1, levels, graph, lca);
        }
    }

    private static void Init(int n, int maxN, int[,] lca)
    {
        for (var i = 1; i <= maxN; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (lca[j, i - 1] != -1)
                {
                    var parent = lca[j, i - 1];
                    lca[j, i] = lca[parent, i - 1];
                }
            }
        }
    }

    private static int FindLca(int a, int b, int maxN, int[] levels, int[,] lca)
    {
        if (levels[a] > levels[b])
        {
            (a, b) = (b, a);
        }

        var d = levels[b] - levels[a];

        while (d > 0)
        {
            var jump = (int)Math.Log2(d);
            b = lca[b, jump];
            d -= 1 << jump;
        }

        if (a == b)
        {
            return a;
        }

        for (var i = maxN; i >= 0; i--)
        {
            if (lca[a, i] != -1 && lca[a, i] != lca[b, i])
            {
                a = lca[a, i];
                b = lca[b, i];
            }
        }

        return lca[a, 0];
    }

    private static int GetDistance(int u, int v, int maxN, int[] levels, int[,] lca)
    {
        var ancestor = FindLca(u, v, maxN, levels, lca);
        return levels[u] + levels[v] - 2 * levels[ancestor];
    }

    private static long PowerMod(long x, long y, int mod)
    {
        long result = 1;

        while (y > 0)
        {
            if ((y & 1) != 0)
            {
                result = (result * x) % mod;
            }

            x = (x * x) % mod;
            y >>= 1;
        }

        return result;
    }
}