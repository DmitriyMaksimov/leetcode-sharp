namespace leetcode_sharp;

// 2925. Maximum Score After Applying Operations on a Tree
// https://leetcode.com/problems/maximum-score-after-applying-operations-on-a-tree
public class S02925
{
    private List<int>[] _adj = [];

    public long MaximumScoreAfterOperations(int[][] edges, int[] values)
    {
        var n = values.Length;
        _adj = new List<int>[n];
        for (var i = 0; i < n; i++)
        {
            _adj[i] = [];
        }

        foreach (var e in edges)
        {
            _adj[e[0]].Add(e[1]);
            _adj[e[1]].Add(e[0]);
        }

        var total = values.Aggregate<int, long>(0, (current, v) => current + v);

        var minLoss = Solve(0, -1, values);

        return total - minLoss;
    }

    private long Solve(int node, int parent, int[] values)
    {
        if (_adj[node].Count == 1 && node != 0)
        {
            return values[node];
        }

        var sum = _adj[node].Where(neighbor => neighbor != parent).Sum(neighbor => Solve(neighbor, node, values));

        return Math.Min(sum, values[node]);
    }
}