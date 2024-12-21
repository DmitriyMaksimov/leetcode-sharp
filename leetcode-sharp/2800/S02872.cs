namespace leetcode_sharp;

// 2872. Maximum Number of K-Divisible Components
// https://leetcode.com/problems/maximum-number-of-k-divisible-components
public class S02872
{
    private long[] _dp = null!;
    private bool[] _visited = null!;
    private int _result;

    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
    {
        _dp = values.Select(x => (long)x).ToArray();

        var adj = new List<int>[n];
        for (var i = 0; i < n; i++)
        {
            adj[i] = [];
        }

        foreach (var edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        _visited = new bool[n];

        Dfs(adj, 0, k);

        return _result;
    }

    private long Dfs(List<int>[] adj, int s, int k)
    {
        _visited[s] = true;

        foreach (var nbr in adj[s].Where(nbr => !_visited[nbr]))
        {
            _dp[s] += Dfs(adj, nbr, k);
        }

        if (_dp[s] % k != 0)
        {
            return _dp[s];
        }

        _result++;

        return 0;
    }
}
