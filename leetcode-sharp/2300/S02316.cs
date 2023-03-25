namespace leetcode_sharp;

// 2316. Count Unreachable Pairs of Nodes in an Undirected Graph
// https://leetcode.com/problems/count-unreachable-pairs-of-nodes-in-an-undirected-graph/
public class S02316
{
    private bool[] _visited;
    private Dictionary<int, List<int>> _graph;
    private int _count;

    public long CountPairs(int n, int[][] edges)
    {
        _graph = buildGraph(edges);
        var res = 0L;
        long sum = n;
        _visited = new bool[n];

        for (var i = 0; i < n; i++)
        {
            if (_visited[i]) continue;
            
            _count = 0;
            var curr = dfs(i);
            sum -= curr;
            res += curr * sum;
        }

        return res;
    }

    private int dfs(int node)
    {
        if (_visited[node]) return _count;
        
        _visited[node] = true;
        
        _count++;

        foreach (var currNode in _graph.GetValueOrDefault(node, Enumerable.Empty<int>().ToList()))
        {
            dfs(currNode);
        }

        return _count;
    }

    private static Dictionary<int, List<int>> buildGraph(int[][] edges)
    {
        var graph = new Dictionary<int, List<int>>();

        foreach (var edge in edges)
        {
            var nodeA = edge[0];
            var nodeB = edge[1];

            graph[nodeA] = graph.GetValueOrDefault(nodeA, new List<int>());
            graph[nodeA].Add(nodeB);

            graph[nodeB] = graph.GetValueOrDefault(nodeB, new List<int>());
            graph[nodeB].Add(nodeA);
        }

        return graph;
    }
}