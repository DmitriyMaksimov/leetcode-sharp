namespace leetcode_sharp;

// 2322. Minimum Score After Removals on a Tree
// https://leetcode.com/problems/minimum-score-after-removals-on-a-tree
public class S02322
{
    private int[] _subtreeXors = null!;
    private HashSet<int>[] _descendants = null!;
    private List<int>[] _graph = null!;

    public int MinimumScore(int[] nums, int[][] edges)
    {
        var nodeCount = nums.Length;
        _graph = new List<int>[nodeCount];
        for (var i = 0; i < nodeCount; i++)
        {
            _graph[i] = [];
        }

        foreach (var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];
            _graph[u].Add(v);
            _graph[v].Add(u);
        }

        _subtreeXors = new int[nodeCount];
        _descendants = new HashSet<int>[nodeCount];
        for (var i = 0; i < nodeCount; i++)
        {
            _descendants[i] = [];
        }

        Dfs(0, -1, nums);

        var totalXor = _subtreeXors[0];
        var minimumScore = int.MaxValue;

        for (var i = 1; i < nodeCount; i++)
        {
            for (var j = i + 1; j < nodeCount; j++)
            {
                var xorI = _subtreeXors[i];
                var xorJ = _subtreeXors[j];

                int val1, val2, val3;

                if (_descendants[i].Contains(j))
                {
                    val1 = xorJ;
                    val2 = xorI ^ xorJ;
                    val3 = totalXor ^ xorI;
                }
                else if (_descendants[j].Contains(i))
                {
                    val1 = xorI;
                    val2 = xorJ ^ xorI;
                    val3 = totalXor ^ xorJ;
                }
                else
                {
                    val1 = xorI;
                    val2 = xorJ;
                    val3 = totalXor ^ xorI ^ xorJ;
                }

                var maxVal = Math.Max(val1, Math.Max(val2, val3));
                var minVal = Math.Min(val1, Math.Min(val2, val3));
                minimumScore = Math.Min(minimumScore, maxVal - minVal);
            }
        }

        return minimumScore;
    }

    private void Dfs(int node, int parent, int[] nodeValues)
    {
        _subtreeXors[node] = nodeValues[node];
        _descendants[node].Add(node);

        foreach (var neighbor in _graph[node])
        {
            if (neighbor == parent)
                continue;

            Dfs(neighbor, node, nodeValues);
            _subtreeXors[node] ^= _subtreeXors[neighbor];
            _descendants[node].UnionWith(_descendants[neighbor]);
        }
    }
}