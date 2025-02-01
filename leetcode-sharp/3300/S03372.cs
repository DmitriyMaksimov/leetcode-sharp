namespace leetcode_sharp;

// 3372. Maximize the Number of Target Nodes After Connecting Trees I
// https://leetcode.com/problems/maximize-the-number-of-target-nodes-after-connecting-trees-i
public class S03372
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        var graph1 = BuildGraph(edges1);
        var graph2 = BuildGraph(edges2);
        var count = 0;
        var n = edges1.Length + 1;
        var m = edges2.Length + 1;

        for (var i = 0; i < m; ++i)
        {
            count = Math.Max(count, Dfs(graph2, i, -1, k - 1));
        }

        var result = new int[n];

        for (var i = 0; i < n; ++i)
        {
            result[i] = count + Dfs(graph1, i, -1, k);
        }

        return result;
    }

    private static List<List<int>> BuildGraph(int[][] edges)
    {
        var graph = new List<List<int>>(new List<int>[edges.Length + 1]);

        for (var i = 0; i < graph.Count; i++)
        {
            graph[i] = [];
        }

        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }

        return graph;
    }

    private static int Dfs(List<List<int>> g, int root, int par, int k, int count = 1)
    {
        if (k < 0)
        {
            return 0;
        }

        foreach (var node in g[root])
        {
            if (node != par)
            {
                count += Dfs(g, node, root, k - 1);
            }
        }

        return count;
    }
}
