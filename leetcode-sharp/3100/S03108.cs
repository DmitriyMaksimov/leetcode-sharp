namespace leetcode_sharp;

// 3108. Minimum Cost Walk in Weighted Graph
// https://leetcode.com/problems/minimum-cost-walk-in-weighted-graph
public class S03108
{
    private bool[] _visited = null!;

    public int[] MinimumCost(int n, int[][] edges, int[][] query)
    {
        var edgesLength = edges.Length;
        var adj = new List<List<int>>(n);

        for (var i = 0; i < n; i++)
        {
            adj.Add([]);
        }

        for (var i = 0; i < edgesLength; i++)
        {
            adj[edges[i][0]].Add(edges[i][1]);
            adj[edges[i][1]].Add(edges[i][0]);
        }

        var mp = new Dictionary<int, int>();
        var flag = 1;
        _visited = new bool[n];

        for (var i = 0; i < n; i++)
        {
            if (!_visited[i])
            {
                Dfs(i, -1, adj, flag, mp);
                flag++;
            }
        }

        var mp2 = Enumerable.Repeat(int.MaxValue, flag + 1).ToArray();

        for (var i = 0; i < edgesLength; i++)
        {
            mp2[mp[edges[i][0]]] &= edges[i][2];
        }

        var queryLength = query.Length;
        var result = new int[queryLength];

        for (var i = 0; i < queryLength; i++)
        {
            if (query[i][0] == query[i][1])
            {
                result[i] = 0;
            }
            else if (mp.TryGetValue(query[i][0], out var value) && mp.TryGetValue(query[i][1], out var value2) && value == value2)
            {
                result[i] = mp2[value];
            }
            else
            {
                result[i] = -1;
            }
        }

        return result;
    }

    private void Dfs(int node, int parent, List<List<int>> adj, int flag, Dictionary<int, int> mp)
    {
        _visited[node] = true;
        mp[node] = flag;

        foreach (var it in adj[node].Where(it => it != parent && !_visited[it]))
        {
            Dfs(it, node, adj, flag, mp);
        }
    }
}
