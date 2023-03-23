namespace leetcode_sharp;

// 1319. Number of Operations to Make Network Connected
// https://leetcode.com/problems/number-of-operations-to-make-network-connected/
public class S01319
{
    private readonly Dictionary<int, List<int>> _graph = new();
    private readonly HashSet<int> _visited = new();

    public int MakeConnected(int n, int[][] connections)
    {
        if (connections.Length < n - 1)
        {
            return -1;
        }

        foreach (var connection in connections)
        {
            _graph[connection[0]] = _graph.GetValueOrDefault(connection[0], new List<int>());
            _graph[connection[0]].Add(connection[1]);

            _graph[connection[1]] = _graph.GetValueOrDefault(connection[1], new List<int>());
            _graph[connection[1]].Add(connection[0]);
        }

        var count = 0;
        for (var i = 0; i < n; i++)
        {
            if (_visited.Contains(i)) continue;
            count++;
            dfs(i);
        }

        return count - 1;
    }

    private void dfs(int node)
    {
        if (_visited.Contains(node))
            return;
        
        _visited.Add(node);
        foreach (var i in _graph.GetValueOrDefault(node, new List<int>()))
        {
            dfs(i);
        }
    }
}