namespace leetcode_sharp;

// 684. Redundant Connection
// https://leetcode.com/problems/redundant-connection
public class S00684
{
    public int[] FindRedundantConnection(int[][] edges)
    {
        int[]? result = null;
        var adjList = Enumerable.Repeat(new HashSet<int>(), 1001).ToList();

        foreach (var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];

            if (Dfs(u, v, 0, adjList))
            {
                result = edge;
            }
            else
            {
                adjList[u].Add(v);
                adjList[v].Add(u);
            }
        }

        return result!;
    }

    private static bool Dfs(int u, int v, int pre, List<HashSet<int>> adjList)
    {
        if (u == v)
        {
            return true;
        }

        foreach (var w in adjList[u].Where(x => x != pre))
        {
            if (Dfs(w, v, u, adjList))
            {
                return true;
            }
        }

        return false;
    }
}
