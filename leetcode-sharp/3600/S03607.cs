namespace leetcode_sharp;

// 3607. Power Grid Maintenance
// https://leetcode.com/problems/power-grid-maintenance
public class S03607
{
    private readonly Dictionary<int, SortedSet<int>> _components = new();
    private bool[] _visited = null!;

    private void Dfs(int start, List<List<int>> adj, int id, int[] ids)
    {
        var stack = new Stack<int>();
        stack.Push(start);
        _components[id] = [];

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (_visited[node])
            {
                continue;
            }

            _visited[node] = true;
            ids[node] = id;
            _components[id].Add(node);

            foreach (var neighbor in adj[node].Where(neighbor => !_visited[neighbor]))
            {
                stack.Push(neighbor);
            }
        }
    }

    public int[] ProcessQueries(int c, int[][] connections, int[][] queries)
    {
        _visited = new bool[c + 1];
        var adjacency = new List<List<int>>(c + 1);
        for (var i = 0; i <= c; i++)
        {
            adjacency.Add([]);
        }

        foreach (var connection in connections)
        {
            var u = connection[0];
            var v = connection[1];
            adjacency[u].Add(v);
            adjacency[v].Add(u);
        }

        var ids = new int[c + 1];

        for (var i = 1; i <= c; i++)
        {
            if (!_visited[i])
            {
                Dfs(i, adjacency, i, ids);
            }
        }

        var result = new List<int>(queries.Length);

        foreach (var query in queries)
        {
            var type = query[0];
            var node = query[1];
            var checkId = ids[node];

            if (!_components.TryGetValue(checkId, out var set))
            {
                result.Add(-1);
                continue;
            }

            if (type == 1)
            {
                if (set.Contains(node))
                {
                    result.Add(node);
                }
                else if (set.Count > 0)
                {
                    result.Add(set.Min);
                }
                else
                {
                    result.Add(-1);
                }
            }
            else if (type == 2)
            {
                set.Remove(node);
            }
        }

        return result.ToArray();
    }
}