namespace leetcode_sharp;

// 3558. Number of Ways to Assign Edge Weights I
// https://leetcode.com/problems/number-of-ways-to-assign-edge-weights-i
public class S03558
{
    private const int Mod = 1_000_000_007;

    public int AssignEdgeWeights(int[][] edges)
    {
        var n = edges.Length + 1;
        var adj = new List<List<int>>(new List<int>[n + 1]);

        for (var i = 0; i <= n; i++)
        {
            adj[i] = [];
        }

        foreach (var e in edges)
        {
            var u = e[0];
            var v = e[1];

            adj[u].Add(v);
            adj[v].Add(u);
        }

        var maxDepth = 0;
        var stack = new Stack<int[]>();
        stack.Push([1, 0, 0]);
        var seen = new bool[n + 1];

        while (stack.Count > 0)
        {
            var cur = stack.Pop();
            var u = cur[0];
            var p = cur[1];
            var d = cur[2];

            maxDepth = Math.Max(maxDepth, d);

            foreach (var v in adj[u].Where(v => v != p))
            {
                stack.Push([v, u, d + 1]);
            }
        }

        maxDepth--;

        var result = 1;

        for (var i = 1; i <= maxDepth; i++)
        {
            result = (int)((long)result * 2 % Mod);
        }

        return result;
    }
}
