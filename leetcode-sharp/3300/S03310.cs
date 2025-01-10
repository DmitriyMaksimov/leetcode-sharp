namespace leetcode_sharp;

// 3310. Remove Methods From Project
// https://leetcode.com/problems/remove-methods-from-project
public class S03310
{
    private bool[] _visited = null!;

    public IList<int> RemainingMethods(int n, int k, int[][] invocations)
    {
        var adj = new List<int>[n];
        for (var i = 0; i < n; i++)
        {
            adj[i] = [];
        }

        foreach (var x in invocations)
        {
            adj[x[0]].Add(x[1]);
        }

        _visited = new bool[n];
        Dfs(adj, k);

        var c = false;
        for (var i = 0; i < n; i++)
        {
            var flag = false;
            if (_visited[i])
            {
                continue;
            }

            if (adj[i].Any(x => _visited[x]))
            {
                flag = true;
            }

            if (flag)
            {
                c = true;
                break;
            }
        }

        var result = new List<int>();
        for (var i = 0; i < n; i++)
        {
            if (_visited[i])
            {
                if (c)
                {
                    result.Add(i);
                }
            }
            else
            {
                result.Add(i);
            }
        }

        return result;
    }

    private void Dfs(List<int>[] adj, int node)
    {
        _visited[node] = true;

        foreach (var child in adj[node].Where(child => !_visited[child]))
        {
            Dfs(adj, child);
        }
    }
}
