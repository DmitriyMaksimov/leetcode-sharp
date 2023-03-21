namespace leetcode_sharp;

// 1443. Minimum Time to Collect All Apples in a Tree
// https://leetcode.com/problems/minimum-time-to-collect-all-apples-in-a-tree/
public class S01443
{
    private readonly Dictionary<int, List<int>> _graph = new();
    private IList<bool> _hasApple;
    private readonly HashSet<int> _visited = new();

    public int MinTime(int n, int[][] edges, IList<bool> hasApple)
    {
        _hasApple = hasApple;
        
        foreach (var edge in edges)
        {
            _graph[edge[0]] = _graph.GetValueOrDefault(edge[0], new List<int>());
            _graph[edge[0]].Add(edge[1]);
            _graph[edge[1]] = _graph.GetValueOrDefault(edge[1], new List<int>());
            _graph[edge[1]].Add(edge[0]);
        }
        
        return dfs(0, 0);
    }

    private int dfs(int edge, int cost)
    {
        if (_visited.Contains(edge))
        {
            return 0;
        }

        _visited.Add(edge);

        var childrenCost = 0;
        
        foreach (var node in _graph[edge])
        {
            childrenCost += dfs(node, 2);
        }

        return (childrenCost == 0 && !_hasApple[edge]) ? 0 : (cost + childrenCost);
    }
}