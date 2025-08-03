namespace leetcode_sharp;

// 802. Find Eventual Safe States
// https://leetcode.com/problems/find-eventual-safe-states/
public class S00802
{
    private bool[] _visit = null!;
    private bool[] _inStack = null!;

    public IList<int> EventualSafeNodes(int[][] graph)
    {
        var n = graph.Length;
        _visit = new bool[n];
        _inStack = new bool[n];

        var adj = new List<List<int>>();

        for (var i = 0; i < n; i++)
        {
            adj.Add([]);
            foreach (var node in graph[i])
            {
                adj[i].Add(node);
            }
        }

        for (var i = 0; i < n; i++)
        {
            dfs(i, adj);
        }

        var safeNodes = new List<int>();

        for (var i = 0; i < n; i++)
        {
            if (!_inStack[i])
            {
                safeNodes.Add(i);
            }
        }

        return safeNodes;
    }

    private bool dfs(int node, List<List<int>> adj)
    {
        // If the node is already in the stack, we have a cycle.
        if (_inStack[node])
        {
            return true;
        }

        if (_visit[node])
        {
            return false;
        }

        // Mark the current node as visited and part of current recursion stack.
        _visit[node] = true;
        _inStack[node] = true;
        foreach (var neighbor in adj[node])
        {
            if (dfs(neighbor, adj))
            {
                return true;
            }
        }

        _inStack[node] = false;
        return false;
    }
}