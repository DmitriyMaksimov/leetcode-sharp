namespace leetcode_sharp;

// 2977. Minimum Cost to Convert String II
// https://leetcode.com/problems/minimum-cost-to-convert-string-ii
public class S02977
{
    public long MinimumCost(string source, string target, string[] original, string[] changed, int[] cost)
    {
        var index = new Dictionary<string, int>(StringComparer.Ordinal);

        foreach (var s in original)
        {
            if (!index.ContainsKey(s))
            {
                index[s] = index.Count;
            }
        }

        foreach (var s in changed)
        {
            if (!index.ContainsKey(s))
            {
                index[s] = index.Count;
            }
        }

        var n = index.Count;

        var dist = new long[n, n];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                dist[i, j] = long.MaxValue;
            }

            dist[i, i] = 0;
        }

        for (var i = 0; i < cost.Length; i++)
        {
            var u = index[original[i]];
            var v = index[changed[i]];
            dist[u, v] = Math.Min(dist[u, v], cost[i]);
        }

        for (var k = 0; k < n; k++)
        {
            for (var i = 0; i < n; i++)
            {
                if (dist[i, k] == long.MaxValue)
                {
                    continue;
                }

                for (var j = 0; j < n; j++)
                {
                    if (dist[k, j] == long.MaxValue)
                    {
                        continue;
                    }

                    var via = dist[i, k] + dist[k, j];
                    if (via < dist[i, j])
                    {
                        dist[i, j] = via;
                    }
                }
            }
        }

        var lengths = new HashSet<int>();
        foreach (var s in original)
        {
            lengths.Add(s.Length);
        }

        var m = target.Length;
        var dp = Enumerable.Repeat(long.MaxValue, m + 1).ToArray();
        dp[0] = 0;

        var src = source.AsSpan();
        var tgt = target.AsSpan();

        for (var i = 0; i < m; i++)
        {
            if (dp[i] == long.MaxValue)
            {
                continue;
            }

            if (src[i] == tgt[i])
            {
                dp[i + 1] = Math.Min(dp[i + 1], dp[i]);
            }

            foreach (var len in lengths.Where(len => i + len <= m))
            {
                var sSpan = src.Slice(i, len);
                var tSpan = tgt.Slice(i, len);

                if (!index.TryGetValue(sSpan.ToString(), out var c1))
                {
                    continue;
                }

                if (!index.TryGetValue(tSpan.ToString(), out var c2))
                {
                    continue;
                }

                var d = dist[c1, c2];
                if (d < long.MaxValue)
                {
                    dp[i + len] = Math.Min(dp[i + len], dp[i] + d);
                }
            }
        }

        return dp[m] == long.MaxValue ? -1 : dp[m];
    }
}